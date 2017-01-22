using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Действующего на основании
    /// </summary>
    public class BasisActionConfiguration : BaseDictionaryDaoEntityConfiguration<BasisAction>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public BasisActionConfiguration()
            : base("BasisActions")
        {
           
        }

        #endregion
    }
}
