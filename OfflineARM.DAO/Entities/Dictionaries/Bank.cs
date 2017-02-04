using System.Collections.Generic;

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
