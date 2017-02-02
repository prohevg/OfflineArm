﻿using System;
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
        /// Оплата наличными
        /// </summary>
        IPayNalModel PayNal
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        IPayCardModel PayCard
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        IPayCreditModel PayCredit
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
    }
}
