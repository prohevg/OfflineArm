using System;
using OfflineARM.DAO.Entities.Business.Bases;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public class CardPayment : Payment
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
