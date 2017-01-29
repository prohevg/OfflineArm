using System.Collections.Generic;
using System.Globalization;
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
    public class CharacteristicImp : BaseImp<ICharacteristicModel, ICharacteristicValidator, Characteristic, ICharacteristicRepository>, ICharacteristicImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public CharacteristicImp(UnitOfWork unitOfWork, ICharacteristicValidator validator)
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
        public List<ICharacteristicModel> GetByNomenclatureId(int nomenclatureId)
        {
            var result = new List<ICharacteristicModel>();
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
        protected override ICharacteristicModel ConvertTo(Characteristic daoEntity)
        {
            var model = new CharacteristicModel
            {
                Id = daoEntity.Id,
                Guid = daoEntity.Guid,
                Name = daoEntity.Name
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
        public override Characteristic CreateInternal(ICharacteristicModel model)
        {
            if (model == null)
            {
                return null;
            }

            var result = new Characteristic
            {
                Id = model.Id,
                Guid = model.Guid,
                Name = model.Name
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
        public override Characteristic UpdateDaoInternal(Characteristic daoEntity, ICharacteristicModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Name = model.Name;

            if (model.Nomenclature != null)
            {
                daoEntity.NomenclatureId = model.Nomenclature.Id;
            }

            return daoEntity;
        }

        #endregion
    }
}
