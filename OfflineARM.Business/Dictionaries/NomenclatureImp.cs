using System.Collections.Generic;
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

        #region override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override INomenclatureModel ConvertTo(Nomenclature daoEntity, INomenclatureModel model = null)
        {
            if (model == null)
            {
                model = new NomenclatureModel();
            }

            model.Id = daoEntity.Id;
            model.Guid = daoEntity.Guid;
            //model.Price = daoEntity.Price;
            //model.IsEnabled = daoEntity.IsEnabled;

            //model.Feature = daoEntity.Feature;
            //model.Nomenclature = daoEntity.Nomenclature;

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected override Nomenclature ConvertTo(INomenclatureModel model, Nomenclature daoEntity = null)
        {
            if (daoEntity == null)
            {
                daoEntity = new Nomenclature();
            }

            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            //daoEntity. = model.Price;
            //daoEntity.IsEnabled = model.IsEnabled;

            //daoEntity.Nomenclature = model.Nomenclature;
            //daoEntity.Feature = model.Feature;

            return daoEntity;
        }

        #endregion
    }
}
