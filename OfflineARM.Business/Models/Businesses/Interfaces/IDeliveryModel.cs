using System;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Адрес доставки в заказе
    /// </summary>
    public interface IDeliveryModel : IBaseBusninessModel
    {
        /// <summary>
        /// Заказ
        /// </summary>
        IOrderModel Order
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        string ContactPersonName
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        string ContactPhoneMain
        {
            get;
            set;
        }

        /// <summary>
        /// Дополнительный телефон
        /// </summary>
        string ContactPhoneSecondary
        {
            get;
            set;
        }

        /// <summary>
        /// Дата доставки
        /// </summary>
        DateTime DeliveryDate
        {
            get;
            set;
        }

        /// <summary>
        /// Дом
        /// </summary>
        string House
        {
            get;
            set;
        }

        /// <summary>
        /// Квартира
        /// </summary>
        string Flat
        {
            get;
            set;
        }

        /// <summary>
        /// Этаж
        /// </summary>
        string Floor
        {
            get;
            set;
        }

        /// <summary>
        /// Домон
        /// </summary>
        string Intercom
        {
            get;
            set;
        }

        /// <summary>
        /// Наличие грузового лифта
        /// </summary>
        bool IsCargoLift
        {
            get;
            set;
        }

        /// <summary>
        /// Наличие подъема
        /// </summary>
        bool IsClimb
        {
            get;
            set;
        }

        /// <summary>
        /// Подъезд
        /// </summary>
        string Porch
        {
            get;
            set;
        }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес строкой
        /// </summary>
        string DelivaryAddress
        {
            get;
        }
    }
}
