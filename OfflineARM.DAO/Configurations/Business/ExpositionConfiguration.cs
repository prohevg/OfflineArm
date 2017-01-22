using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Экспозиция
    /// </summary>
    public class ExpositionConfiguration : BaseDaoEntityConfiguration<Exposition>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public ExpositionConfiguration()
            : base("Expositions")
        {
        }

        #endregion
    }
}
