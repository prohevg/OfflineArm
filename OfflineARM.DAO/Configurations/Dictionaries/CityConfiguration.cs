using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация города
    /// </summary>
    public class CityConfiguration : BaseDictionaryDaoEntityConfiguration<City>
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
