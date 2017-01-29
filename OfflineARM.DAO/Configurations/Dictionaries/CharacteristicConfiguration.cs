using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Характеристика номенклатуры
    /// </summary>
    public class CharacteristicConfiguration : BaseDaoEntityConfiguration<Characteristic>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CharacteristicConfiguration()
            : base("Characteristics")
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }

        #endregion
    }
}
