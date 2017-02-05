using System;
using System.Collections.Generic;
using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

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
        /// Клиент физ лицо
        /// </summary>
        public ICustomerPrivateModel CustomerPrivate
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент юр лицо
        /// </summary>
        public ICustomerLegalModel CustomerLegal
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент 
        /// </summary>
        public ICustomerModel Customer
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес доставки в заказе
        /// </summary>
        public IDeliveryModel Delivery
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

        /// <summary>
        /// Список оплат 
        /// </summary>
        public List<IPaymentModel> Payments
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        public List<IOrderSpecificationItemModel> Specifications
        {
            get;
            set;
        }
    }
}
