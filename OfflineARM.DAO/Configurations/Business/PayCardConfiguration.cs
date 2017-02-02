using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата наличными
    /// </summary>
    public class PayCardConfiguration : BaseDaoEntityConfiguration<PayCard>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public PayCardConfiguration()
            : base("PayCards")
        {
            Property(p => p.Number)
               .HasMaxLength(50);
        }

        #endregion
    }
}
