using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Банк
    /// </summary>
    public class Bank : BaseDictionaryDaoEntity
    {
        /// <summary>
        /// Продукты
        /// </summary>
        public virtual ICollection<BankProduct> BankProducts
        {
            get;
            set;
        }
    }
}
