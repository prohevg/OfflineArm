using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderSpecificationRepository : BaseRepository<OrderSpecificationItem>, IOrderSpecificationRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public OrderSpecificationRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
