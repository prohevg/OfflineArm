using System.Collections.Generic;
using System.Linq;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public class NomenclatureRepository : BaseRepository<Nomenclature>, INomenclatureRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public NomenclatureRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion

        #region INomenclatureRepository

        /// <summary>
        /// Вернуть узлы по parentId.
        ///  Если parentId == 0, то узлы верхнего уровня
        /// </summary>
        /// <returns></returns>
        public List<Nomenclature> GetAllByParentId(int parentId)
        {
            if (parentId == 0)
            {
                return DbSet.Where(n => !n.ParentId.HasValue).ToList();
            }

            return DbSet.Where(n => n.ParentId.HasValue && n.ParentId == parentId).ToList();
        }

        /// <summary>
        /// true - если есть дочерние узлы
        /// </summary>
        /// <param name="id">Id номенклатуры</param>
        /// <returns></returns>
        public bool HasChildren(int id)
        {
            return DbSet.Any(n => n.ParentId.HasValue && n.ParentId == id);
        }

        #endregion
    }
}
