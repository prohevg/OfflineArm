using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public class PayNal : BaseDaoEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public decimal Summ
        {
            get;
            set;
        }

        /// <summary>
        /// Номер чека
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        public bool IsInputManual
        {
            get;
            set;
        }
    }
}
