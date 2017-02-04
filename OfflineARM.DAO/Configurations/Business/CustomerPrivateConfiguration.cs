using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class CustomerPrivateConfiguration : BaseDaoEntityConfiguration<CustomerPrivate>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CustomerPrivateConfiguration()
            : base("CustomerPrivates")
        {
            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Address)
               .HasMaxLength(255);

            Property(p => p.Phone)
              .HasMaxLength(20);
        }

        #endregion
    }
}
