using System.Collections.Generic;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries.Interfaces
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public interface IFeatureImp : IBaseImp<IFeatureModel>
    {
        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        List<IFeatureModel> GetByNomenclatureId(int nomenclatureId);
    }
}
