using OfflineARM.Business.Models.Dictionaries.Interfaces;
using System.Collections.Generic;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Business.Dictionaries.Interfaces
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public interface IExpositionImp : IBaseImp<IExpositionModel>
    {
        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        List<IExpositionModel> GetByNomenclatureId(int nomenclatureId);
    }
}
