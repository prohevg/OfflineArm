using System.Collections.Generic;
using System.Linq;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Controllers.Orders.Commands;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.View.Forms.Orders.Commands;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Список заказов
    /// </summary>
    public class OrderListController : BaseCommandController, IOrderListController
    {
        #region поля и свойства

        /// <summary>
        /// View списка заказов
        /// </summary>
        private IOrderListView _orderListView;

        #endregion

        #region IOrderListController

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderListView = (IOrderListView)view;
        }

        /// <summary>
        /// Загрузить данные
        /// </summary>
        public override async void LoadView()
        {
            using (var unit = new UnitOfWork())
            {
                var list = await unit.BusinessesRepositories.OrderRepository.GetAllAsync();

                foreach (var order in list.Data)
                {
                    FillForGrid(order, unit);
                }

                var orderRows = list.Data.Select(order => new OrderRow(order)).ToList();
                var dataResult = new PagedResult<OrderRow>(orderRows, list.Paging.PageNo, list.Paging.PageSize, list.Paging.TotalRecordCount);
                _orderListView.DataBindData(dataResult);
            }
        }

        /// <summary>
        /// Добавить заказ
        /// </summary>
        public void AddNewOrder()
        {
            var orderEditView = IoCControllers.Instance.Get<IOrderEditView>();
            var orderEditController = orderEditView.Controller;
            orderEditController.LoadView();
            if (!orderEditView.AddNewOrder())
            {
                return;
            }

            var order = orderEditController.GetOrder();
            if (order != null)
            {
                using (var unit = new UnitOfWork())
                {
                    FillForGrid(order, unit);
                }

                var orderRow = new OrderRow(order);
                _orderListView.InsertToGrid(orderRow);
            }
        }

        private void FillForGrid(Order order, UnitOfWork unitOfWork)
        {
            if (order.User == null)
            {
                order.User = unitOfWork.DictionaryRepositories.UserRepository.GetById(order.UserId);
            }

            if (order.CustomerLegal == null && order.CustomerLegalId.HasValue)
            {
                order.CustomerLegal = unitOfWork.BusinessesRepositories.CustomerLegalRepository.GetById(order.CustomerLegalId.Value);
            }

            if (order.CustomerPrivate == null && order.CustomerPrivateId.HasValue)
            {
                order.CustomerPrivate = unitOfWork.BusinessesRepositories.CustomerPrivateRepository.GetById(order.CustomerPrivateId.Value);
            }

            if (order.Delivery == null && order.DeliveryId.HasValue)
            {
                order.Delivery = unitOfWork.BusinessesRepositories.DeliveryRepository.GetById(order.DeliveryId.Value);
            }
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
                OrderCommands.OrderAdd,

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
            if (command.Id == OrderCommands.OrderAdd)
            {
                AddNewOrder();
            }
        }

        #endregion
    }
}
