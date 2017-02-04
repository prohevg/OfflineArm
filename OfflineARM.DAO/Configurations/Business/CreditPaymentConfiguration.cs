using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата кредит
    /// </summary>
    public class CreditPaymentConfiguration : BaseDaoEntityConfiguration<CreditPayment>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CreditPaymentConfiguration()
            : base("CreditPayments")
        {
            Property(p => p.OrderId)
                .HasColumnOrder(2);

            Property(p => p.BankOrderNumber)
               .HasMaxLength(100);

            Property(p => p.NameInOrder)
              .HasMaxLength(255);
        }

        #endregion
    }
}
