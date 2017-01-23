using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Базовая конфигурация
    /// </summary>
    public abstract class BaseDictionaryDaoEntityConfiguration<TDaoEntity> : BaseDaoEntityConfiguration<TDaoEntity>
        where TDaoEntity : BaseDictionaryDaoEntity
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="tableName">Наименование таблицы</param>  
        protected BaseDictionaryDaoEntityConfiguration(string tableName)
            : base(tableName)
        {
            this.Property(p => p.Name)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);
        }

        #endregion
    }
}
