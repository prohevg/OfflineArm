﻿using OfflineARM.Business.Models.Businesses.Interfaces;
using System;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public class DeliveryModel : BaseBusninessModel, IDeliveryModel
    {
        /// <summary>
        /// Заказ
        /// </summary>
        public IOrderModel Order
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string ContactPersonName
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string ContactPhoneMain
        {
            get;
            set;
        }

        /// <summary>
        /// Дополнительный телефон
        /// </summary>
        public string ContactPhoneSecondary
        {
            get;
            set;
        }

        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTime DeliveryDate
        {
            get;
            set;
        }

        /// <summary>
        /// Дом
        /// </summary>
        public string House
        {
            get;
            set;
        }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat
        {
            get;
            set;
        }

        /// <summary>
        /// Этаж
        /// </summary>
        public string Floor
        {
            get;
            set;
        }

        /// <summary>
        /// Домон
        /// </summary>
        public string Intercom
        {
            get;
            set;
        }

        /// <summary>
        /// Наличие грузового лифта
        /// </summary>
        public bool IsCargoLift
        {
            get;
            set;
        }

        /// <summary>
        /// Наличие подъема
        /// </summary>
        public bool IsClimb
        {
            get;
            set;
        }


        /// <summary>
        /// Подъезд
        /// </summary>
        public string Porch
        {
            get;
            set;
        }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес строкой
        /// </summary>
        public string DelivaryAddress
        {
            get
            {
                return string.Format("{0}, д. {1}", Address, House);
            }
        }
    }
}