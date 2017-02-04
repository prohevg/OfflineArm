using System.Collections.Generic;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public class ExpositionImp : BaseImp<IExpositionModel, IExpositionValidator, Exposition, IExpositionRepository>, IExpositionImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public ExpositionImp(UnitOfWork unitOfWork, IExpositionValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.ExpositionRepository, validator)
        {

        }

        #endregion

        #region IExpositionImp

        /// <summary>
        /// Найти по id номенклатуры
        /// </summary>
        /// <param name="nomenclatureId">id номенклатуры</param>
        /// <returns></returns>
        public List<IExpositionModel> GetByNomenclatureId(int nomenclatureId)
        {
            var result = new List<IExpositionModel>();
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
        protected override IExpositionModel ConvertTo(Exposition daoEntity)
        {
            var model = new ExpositionModel
            {
                Id = daoEntity.Id,
                Guid = daoEntity.Guid,
                Price = daoEntity.Price,
                Count = daoEntity.Count,
                IsEnabled = daoEntity.IsEnabled
            };

            if (daoEntity.NomenclatureId > 0)
            {
                model.Nomenclature = new NomenclatureModel();

                var daoNomencl =_unitOfWork.DictionaryRepositories.NomenclatureRepository.GetById(daoEntity.NomenclatureId);

                model.Nomenclature.Id = daoNomencl.Id;
                model.Nomenclature.Name = daoNomencl.Name;
            }

            if (daoEntity.CharacteristicId > 0)
            {
                model.Characteristic = new FeatureModel();

                var daoNomencl = _unitOfWork.DictionaryRepositories.CharacteristicRepository.GetById(daoEntity.CharacteristicId);

                model.Characteristic.Id = daoNomencl.Id;
                model.Characteristic.Name = daoNomencl.Name;
            }

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        public override Exposition CreateInternal(IExpositionModel model)
        {
            if (model == null)
            {
                return null;
            }

            var result = new Exposition
            {
                Id = model.Id,
                Guid = model.Guid,
                Price = model.Price,
                Count = model.Count,
                IsEnabled = model.IsEnabled
            };

            if (model.Nomenclature != null)
            {
                result.NomenclatureId = model.Nomenclature.Id;
            }

            if (model.Characteristic != null)
            {
                result.CharacteristicId = model.Characteristic.Id;
            }

            return result;
        }

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">dao Сущность</param>
        /// <returns></returns>
        public override Exposition UpdateDaoInternal(Exposition daoEntity, IExpositionModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Price = model.Price;
            daoEntity.Count = model.Count;
            daoEntity.IsEnabled = model.IsEnabled;

            if (model.Nomenclature != null)
            {
                daoEntity.NomenclatureId = model.Nomenclature.Id;
            }

            if (model.Characteristic != null)
            {
                daoEntity.CharacteristicId = model.Characteristic.Id;
            }

            return daoEntity;
        }

        #endregion
    }
}
