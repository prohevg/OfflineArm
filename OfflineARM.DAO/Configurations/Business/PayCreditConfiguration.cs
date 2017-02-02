using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата кредит
    /// </summary>
    public class PayCreditConfiguration : BaseDaoEntityConfiguration<PayCredit>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public PayCreditConfiguration()
            : base("PayCredits")
        {
            Property(p => p.CreditBank)
               .HasMaxLength(100);

            Property(p => p.CreditProgramm)
               .HasMaxLength(100);

            Property(p => p.Number)
               .HasMaxLength(50);
      
            Property(p => p.Scanner)
             .HasMaxLength(255);
        }

        #endregion
    }
}
