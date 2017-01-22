using OfflineARM.DAO;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Действующего на основании
    /// </summary>
    public class BasisActionRepository : BaseRepository<BasisAction>, IBasisActionRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public BasisActionRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
