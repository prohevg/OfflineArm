using OfflineARM.DAO;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Местонахождениe
    /// </summary>
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public LocationRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
