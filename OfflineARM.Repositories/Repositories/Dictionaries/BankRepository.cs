using OfflineARM.DAO;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Банк
    /// </summary>
    public class BankRepository : BaseRepository<Bank>, IBankRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public BankRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
