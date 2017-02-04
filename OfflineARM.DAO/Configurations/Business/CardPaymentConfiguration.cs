using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата наличными
    /// </summary>
    public class CardPaymentConfiguration : BaseDaoEntityConfiguration<CardPayment>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public CardPaymentConfiguration()
            : base("CardPayments")
        {
            Property(p => p.OrderId)
                .HasColumnOrder(2);

            Property(p => p.CardNumber)
               .HasMaxLength(50);

            Property(p => p.RNN)
              .HasMaxLength(50);
        }

        #endregion
    }
}
