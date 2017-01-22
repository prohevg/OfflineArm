using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Магазин\салон
    /// </summary>
    public class ShopConfiguration : BaseDaoEntityConfiguration<Shop>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public ShopConfiguration()
            : base("Shops")
        {
            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Address)
                .HasMaxLength(1000);

            Property(p => p.Phone)
               .HasMaxLength(30);
        }

        #endregion
    }
}
