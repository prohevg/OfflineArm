using System;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Адрес
    /// </summary>
    public interface IOrderAddressView
    {
        /// <summary>
        /// Адрес
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        string Flat { get; set; }

        /// <summary>
        /// Подъезд
        /// </summary>
        string Porch { get; set; }

        /// <summary>
        /// Этаж
        /// </summary>
        string Floor { get; set; }

        /// <summary>
        /// Домон
        /// </summary>
        string Intercom { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        string ContactPhoneMain { get; set; }

        /// <summary>
        /// Дополнительный телефон
        /// </summary>
        string ContactPhoneSecondary { get; set; }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        string ContactPersonName { get; set; }

        /// <summary>
        /// Наличие грузового лифта
        /// </summary>
        bool IsCargoLift { get; set; }

        /// <summary>
        /// Наличие подъема
        /// </summary>
        bool IsClimb { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// Дата доставки
        /// </summary>
        DateTime DeliveryDate { get; set; }
    }
}
