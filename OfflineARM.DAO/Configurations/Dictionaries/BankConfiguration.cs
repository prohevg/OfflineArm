using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Банк
    /// </summary>
    public class BankConfiguration : BaseDictionaryDaoEntityConfiguration<Bank>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public BankConfiguration()
            : base("Banks")
        {
           
        }

        #endregion
    }
}
