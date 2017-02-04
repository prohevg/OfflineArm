using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class CustomerPrivateRepository : BaseRepository<CustomerPrivate>, ICustomerPrivateRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CustomerPrivateRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
