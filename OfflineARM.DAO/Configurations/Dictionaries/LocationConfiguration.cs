using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Местонахождениe
    /// </summary>
    public class LocationConfiguration : BaseDictionaryDaoEntityConfiguration<Location>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public LocationConfiguration()
            : base("Locations")
        {
           
        }

        #endregion
    }
}
