using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public class CreditPaymentModel : PaymentModel, ICreditPaymentModel
    {
        /// <summary>
        /// Банк
        /// </summary>
        public IBankModel Bank
        {
            get;
            set;
        }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        public IBankProductModel BankProduct
        {
            get;
            set;
        }

        /// <summary>
        /// № договора
        /// </summary>
        public string BankOrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        public decimal InitialFee
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        public decimal CreditAmount
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string NameInOrder
        {
            get;
            set;
        }
    }
}
