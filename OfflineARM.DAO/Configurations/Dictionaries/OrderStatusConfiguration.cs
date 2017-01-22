using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Configurations.Dictionaries
{
    /// <summary>
    /// Конфигурация Статус заказа
    /// </summary>
    public class OrderStatusConfiguration : BaseDictionaryDaoEntityConfiguration<OrderStatus>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public OrderStatusConfiguration()
            : base("OrderStatuses")
        {
           
        }

        #endregion
    }
}
