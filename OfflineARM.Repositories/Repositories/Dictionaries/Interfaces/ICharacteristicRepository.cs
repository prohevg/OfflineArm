using System.Collections.Generic;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Repositories.Repositories.Dictionaries.Interfaces
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public interface ICharacteristicRepository : IBaseRepository<Characteristic>
    {
        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        List<Characteristic> GetByNomenclatureId(int nomenclatureId);
    }
}
