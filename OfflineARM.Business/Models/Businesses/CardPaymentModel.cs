using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public class CardPaymentModel : PaymentModel, ICardPaymentModel
    {
        /// <summary>
        /// Номер карты
        /// </summary>
        public string CardNumber
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

        /// <summary>
        /// Номер карты
        /// </summary>
        public string RNN
        {
            get;
            set;
        }
    }
}
