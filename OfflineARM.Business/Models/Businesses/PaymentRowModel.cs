using OfflineARM.Business.Models.Businesses.Bases;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Описание оплаты в таблице
    /// </summary>
    public class PaymentRowModel : PaymentModel
    {
        /// <summary>
        /// тип оплаты
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Введен вручную
        /// </summary>
        public bool IsManual
        {
            get;
            set;
        }
    }
}
