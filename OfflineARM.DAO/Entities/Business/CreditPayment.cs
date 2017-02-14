using OfflineARM.DAO.Entities.Business.Bases;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public class CreditPayment : Payment
    {
        /// <summary>
        /// Банк
        /// </summary>
        public int BankId
        {
            get;
            set;
        }

        /// <summary>
        /// Банк
        /// </summary>
        public Bank Bank
        {
            get;
            set;
        }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        public int BankProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        public BankProduct BankProduct
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
        /// Сумма кредита по БС
        /// </summary>
        public decimal CreditAmount
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
        /// ФИО клиента
        /// </summary>
        public string NameInOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование документа
        /// </summary>
        public string DocumentName
        {
            get;
            set;
        }
    }
}
