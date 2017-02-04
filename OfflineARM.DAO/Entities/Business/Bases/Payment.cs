using System;

namespace OfflineARM.DAO.Entities.Business.Bases
{
    /// <summary>
    /// Базовый класс оплаты
    /// </summary>
    public abstract class Payment : BaseDaoEntity
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
        /// Сумма
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        public DateTime PaymentDate
        {
            get;
            set;
        }
    }
}
