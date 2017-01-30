using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public OrderRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
