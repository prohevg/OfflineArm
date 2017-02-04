using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public interface ICreditPaymentModel : IPaymentModel
    {
        /// <summary>
        /// Банк
        /// </summary>
        IBankModel Bank
        {
            get;
            set;
        }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        IBankProductModel BankProduct
        {
            get;
            set;
        }

        /// <summary>
        /// № договора
        /// </summary>
        string BankOrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        decimal InitialFee
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        decimal CreditAmount
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        string NameInOrder
        {
            get;
            set;
        }
    }
}
