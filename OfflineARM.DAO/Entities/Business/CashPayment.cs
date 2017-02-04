using OfflineARM.DAO.Entities.Business.Bases;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public class CashPayment : Payment
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
