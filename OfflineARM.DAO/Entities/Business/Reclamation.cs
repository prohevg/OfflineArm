using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Рекламация
    /// </summary>
    public class Reclamation : BaseDaoEntity
    {
        /// <summary>
        /// Заказ
        /// </summary>
        public int OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// Заказ
        /// </summary>
        public Order Order
        {
            get;
            set;
        }

        /// <summary>
        /// Позиция из заказа
        /// </summary>
        public int OrderSpecificationId
        {
            get;
            set;
        }

        /// <summary>
        /// Позиция из заказа
        /// </summary>
        public OrderSpecification OrderSpecification
        {
            get;
            set;
        }

        /// <summary>
        /// Номер рекламации
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Обращение клиента
        /// </summary>
        public string CustomerContacting
        {
            get;
            set;
        }

        /// <summary>
        /// Требование клиента
        /// </summary>
        public string CustomerRequirement
        {
            get;
            set;
        }

        /// <summary>
        /// Наличие дефекта
        /// </summary>
        public bool IsHasDefect
        {
            get;
            set;
        }

        /// <summary>
        /// Дата создания рекламации
        /// </summary>
        public DateTime DateCreate
        {
            get;
            set;
        }

        /// <summary>
        /// Старт обработки
        /// </summary>
        public DateTime DateStart
        {
            get;
            set;
        }

        /// <summary>
        /// Oкончание обработки
        /// </summary>
        public DateTime DateEnd
        {
            get;
            set;
        }

        /// <summary>
        ///  Доп.телефон
        /// </summary>
        public string PhoneSecond
        {
            get;
            set;
        }
    }
}
