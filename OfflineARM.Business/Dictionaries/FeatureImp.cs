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
    /// Характеристика номенклатуры
    /// </summary>
    public class FeatureImp : BaseImp<IFeatureModel, IFeatureValidator, Feature, ICharacteristicRepository>, IFeatureImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public FeatureImp(UnitOfWork unitOfWork, IFeatureValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.CharacteristicRepository, validator)
        {

        }

        #endregion

        #region ICharacteristicImp

        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        public List<IFeatureModel> GetByNomenclatureId(int nomenclatureId)
        {
            var result = new List<IFeatureModel>();
            var list = _repository.GetByNomenclatureId(nomenclatureId);

            foreach (var daoEntity in list)
            {
                result.Add(ConvertTo(daoEntity));
            }

            return result;
        }

        #endregion

        #region override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity"></param>
        /// <returns></returns>
        protected override IFeatureModel ConvertTo(Feature daoEntity)
        {
            var model = new FeatureModel
            {
                Id = daoEntity.Id,
                Guid = daoEntity.Guid,
                Name = daoEntity.Name,
                Price = daoEntity.Price
            };

            if (daoEntity.NomenclatureId > 0)
            {
                model.Nomenclature = new NomenclatureModel();

                var daoNomencl =_unitOfWork.DictionaryRepositories.NomenclatureRepository.GetById(daoEntity.NomenclatureId);

                model.Nomenclature.Id = daoNomencl.Id;
                model.Nomenclature.Name = daoNomencl.Name;
            }

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        public override Feature CreateInternal(IFeatureModel model)
        {
            if (model == null)
            {
                return null;
            }

            var result = new Feature
            {
                Id = model.Id,
                Guid = model.Guid,
                Name = model.Name,
                Price = model.Price
            };

            if (model.Nomenclature != null)
            {
                result.NomenclatureId = model.Nomenclature.Id;
            }

            return result;
        }

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">dao Сущность</param>
        /// <returns></returns>
        public override Feature UpdateDaoInternal(Feature daoEntity, IFeatureModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Name = model.Name;
            daoEntity.Price = model.Price;

            if (model.Nomenclature != null)
            {
                daoEntity.NomenclatureId = model.Nomenclature.Id;
            }

            return daoEntity;
        }

        #endregion
    }
}
