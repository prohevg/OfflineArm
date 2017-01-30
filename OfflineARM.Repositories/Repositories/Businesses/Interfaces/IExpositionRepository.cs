using System.Collections.Generic;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Repositories.Repositories.Dictionaries.Interfaces
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public interface IExpositionRepository : IBaseRepository<Exposition>
    {
        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        List<Exposition> GetByNomenclatureId(int nomenclatureId);
    }
}
