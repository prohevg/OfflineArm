using System.Collections.Generic;
using OfflineARM.Business.Models.Businesses.Bases;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public interface IOrderPayControl
    {
        /// <summary>
        /// Оплаты
        /// </summary>
        List<IPaymentModel> Payments { get; set; }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        decimal TotalAmount
        {
            get;
            set;
        }
    }
}
