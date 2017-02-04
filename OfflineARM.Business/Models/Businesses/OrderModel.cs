using System;
using System.Collections.Generic;
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
        /// Список оплат наличными
        /// </summary>
        public List<ICashPaymentModel> PayNals
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат кредитом
        /// </summary>
        public List<ICreditPaymentModel> PayCredits
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат картой
        /// </summary>
        public List<ICardPaymentModel> PayCards
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        public List<IOrderSpecificationItemModel> OrderSpecifications
        {
            get;
            set;
        }
    }
}
