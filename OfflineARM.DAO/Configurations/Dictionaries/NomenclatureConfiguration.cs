using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
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

            HasOptional(c => c.Parent)
                    .WithMany()
                    .HasForeignKey(c => c.ParentId);
        }

        #endregion
    }
}
