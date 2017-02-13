using System;
using System.Collections.Generic;
using System.Linq;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Controllers.Orders.Commands;
using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.View.Forms.Orders.Commands;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Редактирование заказа
    /// </summary>
    public class OrderEditController : BaseCommandController, IOrderEditController
    {
        #region поля и свойства

        /// <summary>
        /// View списка заказов
        /// </summary>
        private IOrderEditView _orderEditView;

        /// <summary>
        /// Спецификация
        /// </summary>
        private IOrderPartSpecificController _specificController;

        /// <summary>
        /// Доставка
        /// </summary>
        private IOrderPartDeliveryController _delivaryController;

        /// <summary>
        /// Оплата
        /// </summary>
        private IOrderPartPayController _payController;

        /// <summary>
        /// Ответсвенный
        /// </summary>
        private User _user;
    
        /// <summary>
        /// Заказ
        /// </summary>
        private Order _order;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderEditView = (IOrderEditView)view;
        }

        /// <summary>
        /// Загрузка данных формы
        /// </summary>
        public override async void LoadView()
        {
            using (var unit = new UnitOfWork())
            {
                var allUsers = await unit.DictionaryRepositories.UserRepository.GetAllAsync();

                if (allUsers.Data.Count > 0)
                {
                    _user = allUsers.Data[0];
                }

                _orderEditView.LoadResponsibles(allUsers, _user);
            }

            _specificController.LoadView();
            _delivaryController.LoadView();
            _payController.LoadView();
        }

        #endregion

        #region IOrderEditController

        /// <summary>
        /// Созданный заказ
        /// </summary>
        /// <returns></returns>
        public Order GetOrder()
        {
            return _order;
        }

        /// <summary>
        /// Контроллеры
        /// </summary>
        /// <param name="specificController">Спецификация</param>
        /// <param name="delivaryController">Доставка</param>
        /// <param name="payController">Оплата</param>
        public void SetControllers(IOrderPartSpecificController specificController, IOrderPartDeliveryController delivaryController, IOrderPartPayController payController)
        {
            _specificController = specificController;
            _delivaryController = delivaryController;
            _payController = payController;

            _specificController.MainController = this;
            _delivaryController.MainController = this;
            _payController.MainController = this;
        }

        /// <summary>
        /// Установить ответсвенного
        /// </summary>
        /// <param name="user">Ответсвенный</param>
        public User SetResponsable(User user)
        {
            if (user == null)
            {
                return _user;
            }

            if (_user != null && _user.Guid != user.Guid)
            {
                var autorizationView = IoCControllers.Instance.Get<IAutorizationView>();
                if (autorizationView.ShowDialog())
                {
                    _user = user;
                }
            }

            return _user;
        }

        /// <summary>
        /// Сумма оплат
        /// </summary>
        public void RecalculatePayment()
        {
            var orderAmount = this._specificController.SpecificationItems.Sum(item => item.PriceWithDiscount);
            var amountCashPayments = this._payController.CashPayments.Sum(item => item.Amount);
            var amountCardPayments = this._payController.CardPayments.Sum(item => item.Amount);
            var amountCreditPayments = this._payController.CreditPayments.Sum(item => item.Amount);
            var allAmount = amountCashPayments + amountCardPayments + amountCreditPayments;

            _orderEditView.AmountOrder = string.Format(ControllerResources.OrderEditController_AmountOrder, orderAmount);
            _orderEditView.AmountPayments = string.Format(ControllerResources.OrderEditController_AmountPayments, allAmount);
            _orderEditView.Balance = string.Format(ControllerResources.OrderEditController_AmountBalance, orderAmount - allAmount);
        }

        #endregion

        #region IBaseCommandControl

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            var result = new CommandList(this)
            {
                OrderCommands.Save,

            };

            result.AddDispatched(OrderCommands.OrderPrint, new PrintData());

            return result;
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command">Команда</param>
        public override void Execute(ICommand command)
        {
            if (command.Id == OrderCommands.Save)
            {
                SaveOrder();
            }
        }

        #endregion

        #region private

        /// <summary>
        /// Сохранить заказ
        /// </summary>
        private void SaveOrder()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    _order = new Order()
                    {
                        Guid = Guid.NewGuid(),
                        DateCreate = DateTime.Now,
                        OrderStatus = unitOfWork.DictionaryRepositories.OrderStatusRepository.GetAllAsync().Result.Data.FirstOrDefault(),
                    };

                    AddResponsable(_order);
                    AddCustomer(_order);
                    AddDelivery(_order, unitOfWork);
                    AddOrderSpecifications(_order, unitOfWork);
                    AddPayments(_order);

                    var validator = IoCControllers.Instance.Get<IOrderValidator>();
                    var validatorResult = validator.Validate(_order);

                    if (!validatorResult.IsSucceeded)
                    {
                        var error = validatorResult.Errors.First().Message;
                        IoCControllers.Instance.Get<IMessageBoxView>().Show(error);
                        return;
                    }

                    unitOfWork.BusinessesRepositories.OrderRepository.Insert(_order);
                    unitOfWork.Save();

                    _orderEditView.AddToGridAndClose(_order);
                }
            }
            catch (Exception e)
            {
                _order = null;
                IoCControllers.Instance.Get<IMessageBoxView>().Show(e.Message);
            }
        }

        /// <summary>
        /// Добавить ответсвенного
        /// </summary>
        /// <param name="order"></param>
        private void AddResponsable(Order order)
        {
            if (_user != null)
            {
                if (_user.Id > 0)
                {
                    order.UserId = _user.Id;
                }
                else
                {
                    order.User = _user;
                }
            }
        }

        /// <summary>
        /// Добавить специфификацию
        /// </summary>
        /// <param name="order"></param>
        /// <param name="unitOfWork"></param>
        private void AddOrderSpecifications(Order order, UnitOfWork unitOfWork)
        {
            if (this._specificController.SpecificationItems == null)
            {
                return;
            }

            order.OrderSpecifications = new List<OrderSpecificationItem>();
            foreach (var item in this._specificController.SpecificationItems)
            {
                item.Nomenclature = unitOfWork.DictionaryRepositories.NomenclatureRepository.GetById(item.NomenclatureId);
                item.Feature = unitOfWork.DictionaryRepositories.FeatureRepository.GetById(item.FeatureId);

                order.OrderSpecifications.Add(item);
            }

            _order.TotalAmount = this._specificController.SpecificationItems.Sum(item => item.PriceWithDiscount);
        }

        /// <summary>
        /// Добавить покупателя
        /// </summary>
        /// <param name="order"></param>
        private void AddCustomer(Order order)
        {
            var customerLegal = this._delivaryController.CustomerLegal;
            if (customerLegal != null)
            {
                if (customerLegal.Id > 0)
                {
                    order.CustomerLegalId = customerLegal.Id;
                }
                else
                {
                    order.CustomerLegal = customerLegal;
                }
            }

            var customerPrivate = this._delivaryController.CustomerPrivate;
            if (customerPrivate != null)
            {
                if (customerPrivate.Id > 0)
                {
                    order.CustomerPrivateId = customerPrivate.Id;
                }
                else
                {
                    order.CustomerPrivate = customerPrivate;
                }
            }
        }

        /// <summary>
        /// Доставка заказа
        /// </summary>
        /// <param name="order"></param>
        /// <param name="unitOfWork"></param>
        private void AddDelivery(Order order, UnitOfWork unitOfWork)
        {
            var delivary = this._delivaryController.Delivery;
            //самовывоз
            if (delivary == null)
            {
                return;
            }

            unitOfWork.BusinessesRepositories.DeliveryRepository.Insert(delivary);
            order.Delivery = delivary;
            order.DeliveryId = delivary.Id;
        }

        /// <summary>
        /// оплаты
        /// </summary>
        /// <param name="order"></param>
        private void AddPayments(Order order)
        {
            order.CashPayments = this._payController.CashPayments;
            order.CardPayments = this._payController.CardPayments;
            order.CreditPayments = this._payController.CreditPayments;
        }

        #endregion
    }
}
