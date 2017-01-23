using System.Data.Entity;
using OfflineARM.DAO.Configurations.Business;
using OfflineARM.DAO.Configurations.Dictionaries;


namespace OfflineARM.DAO
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer<ApplicationDbContext>(null);
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
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new BasisActionConfiguration());
            modelBuilder.Configurations.Add(new CustomerRequirementConfiguration());
            modelBuilder.Configurations.Add(new OrderStatusConfiguration());

            modelBuilder.Configurations.Add(new BagCollectionConfiguration());
            modelBuilder.Configurations.Add(new CharacteristicConfiguration());
            modelBuilder.Configurations.Add(new ExpositionConfiguration());
            modelBuilder.Configurations.Add(new NomenclatureConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderSpecificationConfiguration());
            modelBuilder.Configurations.Add(new OrganizationConfiguration());
            modelBuilder.Configurations.Add(new PartnerConfiguration());
            modelBuilder.Configurations.Add(new ReclamationConfiguration());
            modelBuilder.Configurations.Add(new ShopConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        #endregion
    }
}
