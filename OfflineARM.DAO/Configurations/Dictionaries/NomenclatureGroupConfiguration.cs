using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Номенклатура
    /// </summary>
    public class NomenclatureGroupConfiguration : BaseDaoEntityConfiguration<NomenclatureGroup>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public NomenclatureGroupConfiguration()
            : base("NomenclatureGroups")
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }

        #endregion
    }
}
