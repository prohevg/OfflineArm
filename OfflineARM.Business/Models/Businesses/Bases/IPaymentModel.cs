using System;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Bases
{
    /// <summary>
    /// Базовый класс оплаты
    /// </summary>
    public interface IPaymentModel : IBaseBusninessModel
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
        /// Сумма
        /// </summary>
        decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Дата оплаты
        /// </summary>
        DateTime PaymentDate
        {
            get;
            set;
        }
    }
}
