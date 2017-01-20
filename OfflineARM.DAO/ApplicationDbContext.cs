using System.Data.Entity;
using OfflineARM.DAO.Configurations;
using OfflineARM.DAO.Entities;

namespace OfflineARM.DAO
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        #region поля и свойства

        /// <summary>
        /// Список сущностей БД Города
        /// </summary>
        public DbSet<City> Citys
        {
            get;
            set;
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
           // Database.SetInitializer<ApplicationDbContext>(null);
        }

        #endregion

        #region методы

        /// <summary>
        /// Переопредeленный метод создания БД
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CityConfiguration());
        }

        #endregion
    }
}
