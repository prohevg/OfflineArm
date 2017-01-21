using OfflineARM.DAO.Entities;

namespace OfflineARM.DAO.Configurations
{
    /// <summary>
    /// Конфигурация города
    /// </summary>
    public class CityConfiguration : BaseDaoEntityConfiguration<City>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CityConfiguration()
            : base("Citys")
        {
            this.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(255);
        }

        #endregion
    }
}
