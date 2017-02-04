using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities.Business.Bases
{
    /// <summary>
    /// Базовый тип покупателя
    /// </summary>
    public abstract class Customer : BaseDaoEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone
        {
            get;
            set;
        }
    }
}
