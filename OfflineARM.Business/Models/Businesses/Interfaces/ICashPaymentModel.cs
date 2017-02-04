using OfflineARM.Business.Models.Businesses.Bases;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public interface ICashPaymentModel : IPaymentModel
    {
        /// <summary>
        /// Номер чека
        /// </summary>
        string FiscalReceipt
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        bool Manual
        {
            get;
            set;
        }
    }
}
