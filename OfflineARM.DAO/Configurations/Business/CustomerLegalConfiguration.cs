using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Пользователь
    /// </summary>
    public class CustomerLegalConfiguration : BaseDaoEntityConfiguration<CustomerLegal>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CustomerLegalConfiguration()
            : base("CustomerLegals")
        {
            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Address)
               .HasMaxLength(255);

            Property(p => p.Phone)
              .HasMaxLength(20);

            Property(p => p.Face)
               .HasMaxLength(100);

            Property(p => p.Position)
              .HasMaxLength(100);

            Property(p => p.DocNumber)
             .HasMaxLength(100);

            Property(p => p.Inn)
            .HasMaxLength(20);

            Property(p => p.Kpp)
            .HasMaxLength(20);
        }

        #endregion
    }
}
