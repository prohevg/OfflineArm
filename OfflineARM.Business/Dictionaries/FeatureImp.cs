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
    public class FeatureImp : BaseImp<IFeatureModel, IFeatureValidator, Feature, IFeatureRepository>, IFeatureImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public FeatureImp(UnitOfWork unitOfWork, IFeatureValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.FeatureRepository, validator)
        {

        }

        #endregion

        #region IFeatureImp

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
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IFeatureModel ConvertTo(Feature daoEntity, IFeatureModel model = null)
        {
            if (model == null)
            {
                model = new FeatureModel();
            }

            model.Id = daoEntity.Id;
            model.Guid = daoEntity.Guid;
            model.Name = daoEntity.Name;
            model.Price = daoEntity.Price;
            
            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected override Feature ConvertTo(IFeatureModel model, Feature daoEntity = null)
        {
            if (daoEntity == null)
            {
                daoEntity = new Feature();
            }

            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Name = model.Name;
            daoEntity.Price = model.Price;


            return daoEntity;
        }

        #endregion
    }
}
