using OfflineARM.DAO.Entities;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public interface IPayCreditModel : IBaseDaoEntity
    {
        /// <summary>
        /// Банк по БС
        /// </summary>
        string CreditBank
        {
            get;
            set;
        }

        /// <summary>
        /// Программа по БС
        /// </summary>
        string CreditProgramm
        {
            get;
            set;
        }

        /// <summary>
        /// № договора
        /// </summary>
        string Number
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        string ClientFIO
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        decimal SummPV
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        decimal SummBS
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        string Scanner
        {
            get;
            set;
        }
    }
}
