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
        /// <param name="daoEntity"></param>
        /// <returns></returns>
        protected override INomenclatureModel ConvertTo(Nomenclature daoEntity)
        {
            var model = new NomenclatureModel
            {
                Id = daoEntity.Id,
                Guid = daoEntity.Guid,
                Name = daoEntity.Name
            };

            if (daoEntity.ParentId.HasValue)
            {
                model.ParentId = daoEntity.ParentId.Value;
                model.Parent = GetById(daoEntity.ParentId.Value);
            }

            if (daoEntity.Childs != null)
            {
                model.Childs = new List<INomenclatureModel>();
                foreach (var daoEntityChild in daoEntity.Childs)
                {
                    var childModel = ConvertTo(daoEntityChild);
                    model.Childs.Add(childModel);
                }
            }

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        public override Nomenclature CreateInternal(INomenclatureModel model)
        {
            if (model == null)
            {
                return null;
            }

            var result = new Nomenclature
            {
                Id = model.Id,
                Guid = model.Guid,
                Name = model.Name
            };

            if (model.Parent != null)
            {
                result.ParentId = model.Parent.Id;
            }

            //if (model.Childs != null && model.Childs.Count > 0)
            //{
            //    result.Childs = new List<Nomenclature>();
            //    foreach (var modelChild in model.Childs)
            //    {
            //        var daoChildEntity = new Nomenclature()
            //        {
            //            Id = modelChild.Id
            //        };
            //        result.Childs.Add(daoChildEntity);
            //    }
            //}

            return result;
        }

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">dao Сущность</param>
        /// <returns></returns>
        public override Nomenclature UpdateDaoInternal(Nomenclature daoEntity, INomenclatureModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Name = model.Name;

            if (model.Parent != null)
            {
                daoEntity.ParentId = model.Parent.Id;
            }

            //if (model.Childs != null && model.Childs.Count > 0)
            //{
            //    daoEntity.Childs = new List<Nomenclature>();
            //    foreach (var modelChild in model.Childs)
            //    {
            //        var daoChildEntity = new Nomenclature()
            //        {
            //            Id = modelChild.Id
            //        };
            //        daoEntity.Childs.Add(daoChildEntity);
            //    }
            //}

            return daoEntity;
        }

        #endregion
    }
}
