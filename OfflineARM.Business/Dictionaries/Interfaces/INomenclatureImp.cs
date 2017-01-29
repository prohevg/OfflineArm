using System.Collections.Generic;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries.Interfaces
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public interface INomenclatureImp : IBaseImp<INomenclatureModel>
    {
        /// <summary>
        /// Вернуть узлы по parentId.
        ///  Если parentId == 0, то узлы верхнего уровня
        /// </summary>
        /// <returns></returns>
        List<INomenclatureModel> GetAllByParentId(int parentId);

        /// <summary>
        /// true - если есть дочерние узлы
        /// </summary>
        /// <param name="id">Id номенклатуры</param>
        /// <returns></returns>
        bool HasChildren(int id);
    }
}
