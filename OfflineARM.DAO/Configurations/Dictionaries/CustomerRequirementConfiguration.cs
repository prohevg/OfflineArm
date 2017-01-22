using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Требование клиента
    /// </summary>
    public class CustomerRequirementConfiguration : BaseDictionaryDaoEntityConfiguration<CustomerRequirement>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CustomerRequirementConfiguration()
            : base("CustomerRequirements")
        {
           
        }

        #endregion
    }
}
