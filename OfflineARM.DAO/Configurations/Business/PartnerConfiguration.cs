using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Контрагент
    /// </summary>
    public class PartnerConfiguration : BaseDaoEntityConfiguration<Partner>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public PartnerConfiguration()
            : base("Partners")
        {
            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(500);

            Property(p => p.Phone)
               .HasMaxLength(30);

            Property(p => p.LegalAddress)
                .IsRequired()
                .HasMaxLength(500);

            Property(p => p.Person)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Position)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.BasisAction)
               .IsRequired()
               .HasMaxLength(500);

            Property(p => p.Number)
               .IsRequired()
               .HasMaxLength(100);

            Property(p => p.Inn)
               .IsRequired()
               .HasMaxLength(20);

            Property(p => p.Kpp)
               .IsRequired()
               .HasMaxLength(20);
        }

        #endregion
    }
}
