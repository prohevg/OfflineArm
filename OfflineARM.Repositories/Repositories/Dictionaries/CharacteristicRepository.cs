using System.Collections.Generic;
using System.Linq;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public class CharacteristicRepository : BaseRepository<Feature>, ICharacteristicRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CharacteristicRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion

        #region ICharacteristicRepository

        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        public List<Feature> GetByNomenclatureId(int nomenclatureId)
        {
            return DbSet.Where(c => c.NomenclatureId == nomenclatureId).ToList();
        }

        #endregion
    }
}
