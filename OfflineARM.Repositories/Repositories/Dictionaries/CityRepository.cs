using OfflineARM.DAO;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Города
    /// </summary>
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CityRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
