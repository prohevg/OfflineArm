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
    }
}
