using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Требование клиента
    /// </summary>
    public class CustomerRequirementRepository : BaseRepository<ClientRequirement>, ICustomerRequirementRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CustomerRequirementRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
