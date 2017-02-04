using System;
using System.Collections.Generic;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : BaseDaoEntity
    {
        /// <summary>
        /// Ответственный
        /// </summary>
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Ответственный
        /// </summary>
        public User User
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public int OrderStatusId
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public OrderStatus OrderStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент физ лицо
        /// </summary>
        public int CustomerPrivateId
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент физ лицо
        /// </summary>
        public CustomerPrivate CustomerPrivate
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент юр лицо
        /// </summary>
        public int CustomerLegalId
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент юр лицо
        /// </summary>
        public CustomerLegal CustomerLegal
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
        public virtual ICollection<CashPayment> PayNals
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат кредитом
        /// </summary>
        public virtual ICollection<CreditPayment> PayCredits
        {
            get;
            set;
        }

        /// <summary>
        /// Список оплат картой
        /// </summary>
        public virtual ICollection<CardPayment> PayCards
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        public virtual ICollection<OrderSpecificationItem> OrderSpecifications
        {
            get;
            set;
        }
    }
}
