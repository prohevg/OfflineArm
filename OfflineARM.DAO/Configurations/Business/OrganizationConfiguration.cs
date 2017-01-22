using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Организация
    /// </summary>
    public class OrganizationConfiguration : BaseDaoEntityConfiguration<Organization>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public OrganizationConfiguration()
            : base("Organizations")
        {
            Property(p => p.Name)
                .HasMaxLength(255);
        }

        #endregion
    }
}
