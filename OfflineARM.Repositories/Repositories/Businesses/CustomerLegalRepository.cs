using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Клиент юр лицо
    /// </summary>
    public class CustomerLegalRepository : BaseRepository<CustomerLegal>, ICustomerLegalRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CustomerLegalRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
