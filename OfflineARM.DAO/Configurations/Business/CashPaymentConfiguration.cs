using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата наличными
    /// </summary>
    public class CashPaymentConfiguration : BaseDaoEntityConfiguration<CashPayment>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CashPaymentConfiguration()
            : base("CashPayments")
        {
            Property(p => p.OrderId)
                .HasColumnOrder(2);

            Property(p => p.FiscalReceipt)
               .HasMaxLength(50);

            Property(p => p.DocumentName)
                .HasMaxLength(255);
        }

        #endregion
    }
}
