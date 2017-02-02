using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Оплата наличными
    /// </summary>
    public class PayNalConfiguration : BaseDaoEntityConfiguration<PayNal>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public PayNalConfiguration()
            : base("PayNals")
        {
            Property(p => p.Number)
               .HasMaxLength(50);
        }

        #endregion
    }
}
