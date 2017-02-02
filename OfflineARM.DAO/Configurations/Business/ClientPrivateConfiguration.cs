using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class ClientPrivateConfiguration : BaseDaoEntityConfiguration<ClientPrivate>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public ClientPrivateConfiguration()
            : base("ClientPrivates")
        {
            Property(p => p.FIO)
                .HasMaxLength(255);

            Property(p => p.Address)
               .HasMaxLength(255);

            Property(p => p.Phone)
              .HasMaxLength(20);
        }

        #endregion
    }
}
