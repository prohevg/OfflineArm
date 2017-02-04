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
    }
}
