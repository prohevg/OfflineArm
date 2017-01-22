using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public class OrderStatusRepository : BaseRepository<OrderStatus>, IOrderStatusRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public OrderStatusRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
