using System;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Bases
{
    /// <summary>
    /// Базовый класс оплаты
    /// </summary>
    public abstract class PaymentModel : BaseBusninessModel, IPaymentModel
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
