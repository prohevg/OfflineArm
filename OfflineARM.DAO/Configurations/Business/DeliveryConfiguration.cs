using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Магазин\салон
    /// </summary>
    public class DeliveryConfiguration : BaseDaoEntityConfiguration<Delivery>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public DeliveryConfiguration()
            : base("Deliverys")
        {
            Property(p => p.ContactPersonName)
                .HasMaxLength(255);

            Property(p => p.ContactPhoneMain)
                .HasMaxLength(30);

            Property(p => p.ContactPhoneSecondary)
               .HasMaxLength(30);

            Property(p => p.Address)
               .HasMaxLength(255);

            Property(p => p.Comment)
               .HasMaxLength(1000);

            Property(p => p.House)
              .HasMaxLength(10);

            Property(p => p.Flat)
               .HasMaxLength(5);

            Property(p => p.Floor)
              .HasMaxLength(5);

            Property(p => p.Intercom)
             .HasMaxLength(10);

            Property(p => p.Porch)
            .HasMaxLength(5);
        }

        #endregion
    }
}
