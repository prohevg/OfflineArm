using System.Collections.Generic;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries.Interfaces
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public interface ICharacteristicImp : IBaseImp<ICharacteristicModel>
    {
        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        List<ICharacteristicModel> GetByNomenclatureId(int nomenclatureId);
    }
}
