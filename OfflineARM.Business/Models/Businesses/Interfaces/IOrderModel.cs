using System;
using System.Collections.Generic;
using OfflineARM.Business.Models.Businesses.Bases;
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
        /// Клиент 
        /// </summary>
        ICustomerModel Customer
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес доставки в заказе
        /// </summary>
        IDeliveryModel Delivery
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
        /// Сумма заказа
        /// </summary>
        decimal TotalAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат 
        /// </summary>
        List<IPaymentModel> Payments
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        List<IOrderSpecificationItemModel> Specifications
        {
            get;
            set;
        }
    }
}
