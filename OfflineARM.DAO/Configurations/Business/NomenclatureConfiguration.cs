using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Номенклатура
    /// </summary>
    public class NomenclatureConfiguration : BaseDaoEntityConfiguration<Nomenclature>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public NomenclatureConfiguration()
            : base("Nomenclatures")
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }

        #endregion
    }
}
