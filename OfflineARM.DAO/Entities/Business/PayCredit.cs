using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public class PayCredit : BaseDaoEntity
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
    }
}
