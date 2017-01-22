using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Заказ
    /// </summary>
    public class OrderConfiguration : BaseDaoEntityConfiguration<Order>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public OrderConfiguration()
            : base("Orders")
        {
            Property(p => p.Responsible)
                .IsRequired();
        }

        #endregion
    }
}
