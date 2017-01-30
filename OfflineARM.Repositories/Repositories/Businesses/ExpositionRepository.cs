using System.Collections.Generic;
using System.Linq;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public class ExpositionRepository : BaseRepository<Exposition>, IExpositionRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public ExpositionRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion

        #region IExpositionRepository

        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        public List<Exposition> GetByNomenclatureId(int nomenclatureId)
        {
            return DbSet.Where(c => c.NomenclatureId == nomenclatureId).ToList();
        }

        #endregion
    }
}
