using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Спецификация заказа
    /// </summary>
    public class OrderSpecificationConfiguration : BaseDaoEntityConfiguration<OrderSpecification>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public OrderSpecificationConfiguration()
            : base("OrderSpecifications")
        {
        }

        #endregion
    }
}
