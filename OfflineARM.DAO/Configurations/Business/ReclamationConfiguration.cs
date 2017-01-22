using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Рекламация
    /// </summary>
    public class ReclamationConfiguration : BaseDaoEntityConfiguration<Reclamation>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public ReclamationConfiguration()
            : base("Reclamations")
        {
            Property(p => p.CustomerRequirement)
               .IsRequired();

            Property(p => p.Number)
               .HasMaxLength(255);

            Property(p => p.PhoneSecond)
                .HasMaxLength(30);
        }

        #endregion
    }
}
