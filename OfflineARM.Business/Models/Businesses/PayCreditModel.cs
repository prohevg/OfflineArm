using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public class PayCreditModel : BaseDaoEntity, IPayCreditModel
    {
        /// <summary>
        /// Банк по БС
        /// </summary>
        public string CreditBank
        {
            get;
            set;
        }

        /// <summary>
        /// Программа по БС
        /// </summary>
        public string CreditProgramm
        {
            get;
            set;
        }

        /// <summary>
        /// № договора
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string ClientFIO
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        public decimal SummPV
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        public decimal SummBS
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        public string Scanner
        {
            get;
            set;
        }

        #region implicit

        public static implicit operator PayCreditModel(PayCredit value)
        {
            var result = new PayCreditModel
            {
                Id = value.Id,
                Guid = value.Guid, 
                ClientFIO = value.ClientFIO,
                CreditBank = value.CreditBank,
                CreditProgramm = value.CreditProgramm,
                Number = value.Number,
                Scanner = value.Scanner,
                SummBS = value.SummBS,
                SummPV = value.SummPV
            };
            return result;
        }

        public static implicit operator PayCredit(PayCreditModel value)
        {
            var result = new PayCredit
            {
                Id = value.Id,
                Guid = value.Guid,
                ClientFIO = value.ClientFIO,
                CreditBank = value.CreditBank,
                CreditProgramm = value.CreditProgramm,
                Number = value.Number,
                Scanner = value.Scanner,
                SummBS = value.SummBS,
                SummPV = value.SummPV
            };
            return result;
        }

        #endregion
    }
}
