using OfflineARM.Business.Models.Businesses.Bases;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public interface ICardPaymentModel : IPaymentModel
    {
        /// <summary>
        /// Номер карты
        /// </summary>
        string CardNumber
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

        /// <summary>
        /// Номер карты
        /// </summary>
        string RNN
        {
            get;
            set;
        }
    }
}
