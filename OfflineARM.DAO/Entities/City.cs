using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities
{
    /// <summary>
    /// Города
    /// </summary>
    public class City : BaseDaoEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
