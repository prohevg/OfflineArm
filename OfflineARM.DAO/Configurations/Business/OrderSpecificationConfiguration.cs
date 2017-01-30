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
