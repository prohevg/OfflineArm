using System;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Заказ
    /// </summary>
    public interface IOrderModel : IBaseBusninessModel
    {
        /// <summary>
        ///  Номер заказа
        /// </summary>
        string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        string OrderStatus
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
        /// Ответственный
        /// </summary>
        Guid Responsible
        {
            get;
            set;
        }

        /// <summary>
        /// Самовывоз
        /// </summary>
        bool IsSelf
        {
            get;
            set;
        }

        /// <summary>
        /// Дата отгрузки
        /// </summary>
        DateTime DateShipping
        {
            get;
            set;
        }

        /// <summary>
        /// Дата отгрузки
        /// </summary>
        decimal Summa
        {
            get;
            set;
        }
    }
}
