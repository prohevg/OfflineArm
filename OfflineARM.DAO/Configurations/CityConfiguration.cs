using OfflineARM.DAO.Entities;

namespace OfflineARM.DAO.Configurations
{
    /// <summary>
    /// Конфигурация города
    /// </summary>
    public class CityConfiguration : BaseDaoEntityConfiguration<City>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CityConfiguration()
            : base("Citys")
        {

        }

        #endregion
    }
}
