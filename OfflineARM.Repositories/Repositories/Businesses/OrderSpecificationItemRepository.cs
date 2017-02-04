using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderSpecificationItemRepository : BaseRepository<OrderSpecificationItem>, IOrderSpecificationItemRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public OrderSpecificationItemRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
