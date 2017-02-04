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
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IExpositionModel ConvertTo(Exposition daoEntity, IExpositionModel model = null)
        {
            if (model == null)
            {
                model = new ExpositionModel();
            }

            model.Id = daoEntity.Id;
            model.Guid = daoEntity.Guid;
            model.Price = daoEntity.Price;
            model.IsEnabled = daoEntity.IsEnabled;

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
        protected override Exposition ConvertTo(IExpositionModel model, Exposition daoEntity = null)
        {
            if (daoEntity == null)
            {
                daoEntity = new Exposition();
            }

            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Price = model.Price;
            daoEntity.IsEnabled = model.IsEnabled;

            //daoEntity.Nomenclature = model.Nomenclature;
            //daoEntity.Feature = model.Feature;

            return daoEntity;
        }

        #endregion
    }
}
