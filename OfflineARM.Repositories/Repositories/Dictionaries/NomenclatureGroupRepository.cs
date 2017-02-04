using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Группа номенклатур
    /// </summary>
    public class NomenclatureGroupRepository : BaseRepository<NomenclatureGroup>, INomenclatureGroupRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public NomenclatureGroupRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
