using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderImp : BaseImp<IOrderModel, IOrderValidator, Order, IOrderRepository>, IOrderImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public OrderImp(UnitOfWork unitOfWork, IOrderValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.OrderRepository, validator)
        {

        }

        #endregion

        #region override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IOrderModel ConvertTo(Order daoEntity, IOrderModel model = null)
        {
            var result = Mapper.Map<Order, IOrderModel>(daoEntity);

            if (daoEntity.UserId > 0)
            {
                var daoUser = _unitOfWork.DictionaryRepositories.UserRepository.GetById(daoEntity.UserId);
                result.User = Mapper.Map<User, IUserModel>(daoUser);
            }

            if (daoEntity.OrderStatusId > 0)
            {
                var daoOrderStatus = _unitOfWork.DictionaryRepositories.OrderStatusRepository.GetById(daoEntity.OrderStatusId);
                result.OrderStatus = Mapper.Map<OrderStatus, IOrderStatusModel>(daoOrderStatus);
            }

            if (daoEntity.DeliveryId > 0)
            {
                var daoDelivery = _unitOfWork.BusinessesRepositories.DeliveryRepository.GetById(daoEntity.DeliveryId);
                result.Delivery = Mapper.Map<Delivery, IDeliveryModel> (daoDelivery);
            }

            if (daoEntity.CustomerLegalId.HasValue && daoEntity.CustomerLegalId.Value > 0)
            {
                var daoCustomerLegal = _unitOfWork.BusinessesRepositories.CustomerLegalRepository.GetById(daoEntity.CustomerLegalId.Value);
                result.CustomerLegal = Mapper.Map<CustomerLegal, ICustomerLegalModel>(daoCustomerLegal);
            }

            if (daoEntity.CustomerPrivateId.HasValue && daoEntity.CustomerPrivateId.Value > 0)
            {
                var daoCustomerPrivate = _unitOfWork.BusinessesRepositories.CustomerPrivateRepository.GetById(daoEntity.CustomerPrivateId.Value);
                result.CustomerPrivate = Mapper.Map<CustomerPrivate, ICustomerPrivateModel>(daoCustomerPrivate);
            }

            if (result.CustomerLegal != null)
            {
                result.Customer = result.CustomerLegal;
            }
            else
            {
                result.Customer = result.CustomerPrivate;
            }

            result.Number = "Не присвоен";

            return result;
        }

        /// <summary>
        /// Конвертирование DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected override Order ConvertTo(IOrderModel model, Order daoEntity = null)
        {
            var result = Mapper.Map<IOrderModel, Order>(model);

            if (result.CustomerPrivateId > 0)
            {
                result.CustomerPrivate = null;
            }

            if (result.CustomerLegalId > 0)
            {
                result.CustomerLegal = null;
            }

            if (result.OrderStatusId > 0)
            {
                result.OrderStatus = null;
            }

            if (result.UserId > 0)
            {
                result.User = null;
            }

            if (model.Specifications != null)
            {
                var list = new List<OrderSpecificationItem>();
                foreach (var orderSpecificationItemModel in model.Specifications)
                {
                    var spes = Mapper.Map<IOrderSpecificationItemModel, OrderSpecificationItem>(orderSpecificationItemModel);
                    spes.Feature = null;
                    spes.Nomenclature = null;
                    list.Add(spes);
                }
                result.OrderSpecifications = list;
            }

            if (model.Payments != null)
            {
                var cashPayments = model.Payments.OfType<ICashPaymentModel>().ToList();
                if (cashPayments.Any())
                {
                    result.CashPayments = new List<CashPayment>();
                    foreach (var cashPayment in cashPayments)
                    {
                        var daoCashPayment = Mapper.Map<ICashPaymentModel, CashPayment>(cashPayment);
                        result.CashPayments.Add(daoCashPayment);
                    }
                }

                var cardPayments = model.Payments.OfType<ICardPaymentModel>().ToList();
                if (cardPayments.Any())
                {
                    result.CardPayments = new List<CardPayment>();
                    foreach (var cardPayment in cardPayments)
                    {
                        var daoCardPayment = Mapper.Map<ICardPaymentModel, CardPayment>(cardPayment);
                        result.CardPayments.Add(daoCardPayment);
                    }
                }

                var creditPayments = model.Payments.OfType<ICreditPaymentModel>().ToList();
                if (creditPayments.Any())
                {
                    result.CreditPayments = new List<CreditPayment>();
                    foreach (var creditPayment in creditPayments)
                    {
                        var daoCreditPayment = Mapper.Map<ICreditPaymentModel, CreditPayment>(creditPayment);
                        daoCreditPayment.Bank = null;
                        daoCreditPayment.BankProduct = null;
                        result.CreditPayments.Add(daoCreditPayment);
                    }
                }
            }

            return result;
        }

        #endregion
    }
}
