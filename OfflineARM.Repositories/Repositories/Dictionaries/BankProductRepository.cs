using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Банковский продукт
    /// </summary>
    public class BankProductRepository : BaseRepository<BankProduct>, IBankProductRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public BankProductRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
