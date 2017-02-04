using System.Collections.Generic;
using AutoMapper;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public class NomenclatureImp : BaseImp<INomenclatureModel, INomenclatureValidator, Nomenclature, INomenclatureRepository>, INomenclatureImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public NomenclatureImp(UnitOfWork unitOfWork, INomenclatureValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.NomenclatureRepository, validator)
        {

        }

        #endregion

        #region INomenclatureImp

        /// <summary>
        /// Вернуть узлы по parentId.
        ///  Если parentId == 0, то узлы верхнего уровня
        /// </summary>
        /// <returns></returns>
        public List<INomenclatureModel> GetAllByParentId(int parentId)
        {
            var list = _repository.GetAllByParentId(parentId);
            if (list == null)
            {
                return new List<INomenclatureModel>();
            }

            var result = new List<INomenclatureModel>();
            foreach (var daoEntity in list)
            {
                result.Add(ConvertTo(daoEntity));
            }
            return result;
        }

        /// <summary>
        /// true - если есть дочерние узлы
        /// </summary>
        /// <param name="id">Id номенклатуры</param>
        /// <returns></returns>
        public bool HasChildren(int id)
        {
            return _repository.HasChildren(id);
        }

        #endregion
    }
}
