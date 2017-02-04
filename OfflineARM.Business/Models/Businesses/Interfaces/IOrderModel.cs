using System;
using System.Collections.Generic;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Заказ
    /// </summary>
    public interface IOrderModel : IBaseBusninessModel
    {
        /// <summary>
        /// Ответственный
        /// </summary>
        IUserModel User
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        IOrderStatusModel OrderStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент физ лицо
        /// </summary>
        ICustomerPrivateModel CustomerPrivate
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент юр лицо
        /// </summary>
        ICustomerLegalModel CustomerLegal
        {
            get;
            set;
        }

        /// <summary>
        ///  Номер заказа
        /// </summary>
        string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        DateTime DateCreate
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат наличными
        /// </summary>
        List<ICashPaymentModel> PayNals
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат кредитом
        /// </summary>
        List<ICreditPaymentModel> PayCredits
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат картой
        /// </summary>
        List<ICardPaymentModel> PayCards
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        List<IOrderSpecificationItemModel> OrderSpecifications
        {
            get;
            set;
        }
    }
}
