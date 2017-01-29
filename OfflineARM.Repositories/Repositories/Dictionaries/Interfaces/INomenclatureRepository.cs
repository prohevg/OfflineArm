using OfflineARM.DAO.Entities.Dictionaries;
using System.Collections.Generic;

namespace OfflineARM.Repositories.Repositories.Dictionaries.Interfaces
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public interface INomenclatureRepository : IBaseRepository<Nomenclature>
    {
        /// <summary>
        /// Вернуть узлы по parentId.
        ///  Если parentId == 0, то узлы верхнего уровня
        /// </summary>
        /// <returns></returns>
        List<Nomenclature> GetAllByParentId(int parentId);

        /// <summary>
        /// true - если есть дочерние узлы
        /// </summary>
        /// <param name="id">Id номенклатуры</param>
        /// <returns></returns>
        bool HasChildren(int id);
    }
}
