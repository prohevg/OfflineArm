using System.Collections.Generic;
using AutoMapper;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
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

        #region protected override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IExpositionModel ConvertTo(Exposition daoEntity, IExpositionModel model = null)
        {
            var result = Mapper.Map<Exposition, IExpositionModel>(daoEntity);

            if (daoEntity.NomenclatureId > 0)
            {
                var daoNomeclature = _unitOfWork.DictionaryRepositories.NomenclatureRepository.GetById(daoEntity.NomenclatureId);
                result.Nomenclature = Mapper.Map<Nomenclature, INomenclatureModel>(daoNomeclature);
            }

            if (daoEntity.FeatureId > 0)
            {
                var daoFeature = _unitOfWork.DictionaryRepositories.FeatureRepository.GetById(daoEntity.FeatureId);
                result.Feature = Mapper.Map<Feature, IFeatureModel>(daoFeature);
            }
           
            return result;
        }

        #endregion
    }
}
