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

            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new BankProductConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new BasisActionConfiguration());
            modelBuilder.Configurations.Add(new ClientRequirementConfiguration());
            modelBuilder.Configurations.Add(new OrderStatusConfiguration());

            modelBuilder.Configurations.Add(new BagCollectionConfiguration());
            modelBuilder.Configurations.Add(new FeatureConfiguration());
            modelBuilder.Configurations.Add(new ExpositionConfiguration());
            modelBuilder.Configurations.Add(new NomenclatureConfiguration());
            modelBuilder.Configurations.Add(new NomenclatureGroupConfiguration());

            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new CustomerPrivateConfiguration());
            modelBuilder.Configurations.Add(new CustomerLegalConfiguration());
            modelBuilder.Configurations.Add(new CashPaymentConfiguration());
            modelBuilder.Configurations.Add(new CardPaymentConfiguration());
            modelBuilder.Configurations.Add(new CreditPaymentConfiguration());

            modelBuilder.Configurations.Add(new OrderSpecificationItemConfiguration());
            modelBuilder.Configurations.Add(new OrganizationConfiguration());
            modelBuilder.Configurations.Add(new PartnerConfiguration());
            modelBuilder.Configurations.Add(new ReclamationConfiguration());
            modelBuilder.Configurations.Add(new ShopConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        #endregion
    }
}
