using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Helpers;

namespace OfflineARM.DAO.Configurations
{
    /// <summary>
    /// Базовая конфигурация
    /// </summary>
    public abstract class BaseDaoEntityConfiguration<TDaoEntity> : EntityTypeConfiguration<TDaoEntity>
        where TDaoEntity : BaseDaoEntity
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="tableName">Наименование таблицы</param>  
        protected BaseDaoEntityConfiguration(string tableName)
        {
            tableName.ThrowIfNull();

            ToTable(tableName);
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Guid)
               .IsRequired()
               .HasColumnOrder(1);
        }

        #endregion
    }
}
