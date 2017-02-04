using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Банковский продукт
    /// </summary>
    public class BankProductConfiguration : BaseDictionaryDaoEntityConfiguration<BankProduct>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public BankProductConfiguration()
            : base("BankProducts")
        {
            HasRequired(p => p.Bank)
                .WithMany(p => p.BankProducts)
                .HasForeignKey(p => p.BankId)
                .WillCascadeOnDelete(false);
        }

        #endregion
    }
}
