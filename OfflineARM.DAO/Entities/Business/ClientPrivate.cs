using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class ClientPrivate : BaseDaoEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO
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
