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
        /// Оплата наличными
        /// </summary>
        public int? PayNalId
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        public PayNal PayNal
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        public int? PayCardId
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        public PayCard PayCard
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        public int? PayCreditId
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        public PayCredit PayCredit
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
        /// Самовывоз
        /// </summary>
        public bool IsSelf
        {
            get;
            set;
        }

        /// <summary>
        /// Дата отгрузки
        /// </summary>
        public DateTime DateShipping
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма 
        /// </summary>
        public decimal Summa
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        public virtual ICollection<OrderSpecification> OrderSpecifications
        {
            get;
            set;
        }
    }
}
