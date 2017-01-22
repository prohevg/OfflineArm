using System;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : BaseDaoEntity
    {
        /// <summary>
        ///  Номер заказа
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public string OrderStatus
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
        /// Ответственный
        /// </summary>
        public Guid Responsible
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
        /// Дата отгрузки
        /// </summary>
        public decimal Summa
        {
            get;
            set;
        }
    }
}
