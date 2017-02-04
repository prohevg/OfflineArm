using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Configurations.Business
{
    /// <summary>
    /// Конфигурация Спецификация заказа
    /// </summary>
    public class OrderSpecificationItemConfiguration : BaseDaoEntityConfiguration<OrderSpecificationItem>
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        public OrderSpecificationItemConfiguration()
            : base("OrderSpecificationItems")
        {
            HasRequired(m => m.Nomenclature)
                .WithMany(t => t.OrderSpecifications)
                .HasForeignKey(m => m.NomenclatureId)
                .WillCascadeOnDelete(false);

            HasRequired(m => m.Order)
                .WithMany(t => t.OrderSpecifications)
                .HasForeignKey(m => m.OrderId)
                .WillCascadeOnDelete(false);
        }

        #endregion
    }
}
