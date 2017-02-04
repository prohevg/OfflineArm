using System;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderModel : BaseBusninessModel, IOrderModel
    {
        /// <summary>
        /// Ответственный
        /// </summary>
        public IUserModel User
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public IOrderStatusModel OrderStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        public ICashPaymentModel PayNal
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        public ICardPaymentModel PayCard
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        public ICreditPaymentModel PayCredit
        {
            get;
            set;
        }

        /// <summary>
        ///  Номер заказа
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime DateCreate
        {
            get;
            set;
        }
        
        #region implicit

        public static implicit operator OrderModel(Order value)
        {
            var result = new OrderModel
            {
                Id = value.Id,
                Guid = value.Guid
            };

            return result;
        }

        public static implicit operator Order(OrderModel value)
        {
            var result = new Order
            {
                Id = value.Id,
                Guid = value.Guid
            };

            return result;
        }

        #endregion
    }
}
