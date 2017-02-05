using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Адрес доставки в заказе
    /// </summary>
    public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public DeliveryRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
