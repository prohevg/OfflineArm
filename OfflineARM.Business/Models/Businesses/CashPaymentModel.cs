using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public class CashPaymentModel : PaymentModel, ICashPaymentModel
    {
        /// <summary>
        /// Номер чека
        /// </summary>
        public string FiscalReceipt
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        public bool Manual
        {
            get;
            set;
        }
    }
}
