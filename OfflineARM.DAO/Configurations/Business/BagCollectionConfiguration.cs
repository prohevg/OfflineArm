using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Сумка для инкассации
    /// </summary>
    public class BagCollectionConfiguration : BaseDaoEntityConfiguration<BagCollection>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public BagCollectionConfiguration()
            : base("BagCollections")
        {
            
        }

        #endregion
    }
}
