using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Требование клиента
    /// </summary>
    public class ClientRequirementConfiguration : BaseDictionaryDaoEntityConfiguration<ClientRequirement>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public ClientRequirementConfiguration()
            : base("CustomerRequirements")
        {
           
        }

        #endregion
    }
}
