using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Характеристика номенклатуры
    /// </summary>
    public class FeatureConfiguration : BaseDaoEntityConfiguration<Feature>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public FeatureConfiguration()
            : base("Features")
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }

        #endregion
    }
}
