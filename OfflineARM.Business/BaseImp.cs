using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OfflineARM.Business.Models;
using OfflineARM.Business.Validators;
using OfflineARM.DAO.Entities;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories;

namespace OfflineARM.Business
{
    /// <summary>
    /// Базовая реализация логики
    /// </summary>
    public abstract class BaseImp<TModelEntity, TModelEntityValidator, TDaoEntity, TDaoEntityRepository> : IBaseImp<TModelEntity>
       where TModelEntity : class, IBaseBusninessModel
       where TModelEntityValidator : class, IValidator<TModelEntity>
       where TDaoEntity : class, IBaseDaoEntity
       where TDaoEntityRepository : class, IBaseRepository<TDaoEntity>
    {
        #region поля и свойства

        /// <summary>
        /// UnitOfWork
        /// </summary>
        protected readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Валидатор сущности
        /// </summary>
        protected readonly TModelEntityValidator _validator;

        /// <summary>
        /// Репозитарий сущности
        /// </summary>
        protected readonly TDaoEntityRepository _repository;

        #endregion

        #region 

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="repository">Репозитарий сущности</param>
        /// <param name="validator">Валидатор сущности</param>
        protected BaseImp(UnitOfWork unitOfWork, TDaoEntityRepository repository, TModelEntityValidator validator)
        {
            if (validator == null)
            {
                throw new ArgumentNullException("validator");
            }

            if (unitOfWork == null)
            {
                throw new ArgumentNullException("unitOfWork");
            }

            _unitOfWork = unitOfWork;
            _repository = repository;
            _validator = validator;
        }

        #endregion
        
        #region IBaseImp<T>

        /// <summary>
        /// Получить все
        /// </summary>
        public virtual PagedResult<TModelEntity> GetAll()
        {
            var result = new List<TModelEntity>();

            var count = _repository.Count();
            var list = _repository.GetAll();

            if (list == null)
            {
                return new PagedResult<TModelEntity>(result, 1, 1, count);
            }
            
            foreach (var daoEntity in list)
            {
                var modelEntity = ConvertTo(daoEntity);
                result.Add(modelEntity);
            }

            return new PagedResult<TModelEntity>(result, 1, 1, count);
        }

        /// <summary>
        /// Получить все
        /// </summary>
        public virtual Task<PagedResult<TModelEntity>> GetAllAsync()
        {
            return Task.Factory.StartNew(GetAll);
        }

        /// <summary>
        /// Добавить в БД
        /// </summary>
        /// <param name="model">Модель</param>
        /// <returns></returns>
        public virtual ModelEntityModifyResult Insert(TModelEntity model)
        {
            try
            {
                if (model == null)
                {
                    return new ModelEntityModifyResult(ValidatorResources.CommonErrors_ModelIsNull);
                }

                var validateResult = _validator.Validate(model);
                if (!validateResult.IsSucceeded)
                {
                    return new ModelEntityModifyResult(validateResult.Errors);
                }

                var customValidateResult = ValidationInternal(model);
                if (!customValidateResult.IsSucceeded)
                {
                    return new ModelEntityModifyResult(customValidateResult.Errors);
                }

                var daoEntity = ConvertTo(model);

                _repository.Insert(daoEntity);
                _unitOfWork.Save();

                return new ModelEntityModifyResult(daoEntity.Id);
            }
            catch (Exception e)
            {
                var errorData = new ErrorData(e.Message);
                return new ModelEntityModifyResult(errorData);
            }
        }

        /// <summary>
        /// ОБновить в БД
        /// </summary>
        /// <param name="model">Модель</param>
        /// <returns></returns>
        public virtual ModelEntityModifyResult Update(TModelEntity model)
        {
            try
            {
                if (model == null)
                {
                    return new ModelEntityModifyResult(ValidatorResources.CommonErrors_ModelIsNull);
                }

                var validateResult = _validator.Validate(model);
                if (!validateResult.IsSucceeded)
                {
                    return new ModelEntityModifyResult(validateResult.Errors);
                }

                var customValidateResult = ValidationInternal(model);
                if (!customValidateResult.IsSucceeded)
                {
                    return new ModelEntityModifyResult(customValidateResult.Errors);
                }

                var daoEntity = _repository.GetById(model.Id);
                if (daoEntity == null)
                {
                    var errorData = new ErrorData(ValidatorResources.CommonErrors_EntityUpdateNotFound, new object[] { model.Id });
                    return new ModelEntityModifyResult(errorData);
                }

                daoEntity = ConvertTo(model, daoEntity);

                _repository.Update(daoEntity);
                _unitOfWork.Save();

                return new ModelEntityModifyResult();
            }
            catch (Exception e)
            {
                var errorData = new ErrorData(e.Message);
                return new ModelEntityModifyResult(errorData);
            }
        }

        /// <summary>
        /// true - если можно удалить из БД
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        public virtual bool IsCanDelete(int id)
        {
            try
            {
                var daoEntity = _repository.GetById(id);
                if (daoEntity == null)
                {
                    return false;
                }

                var result = CanDeleteInternal(daoEntity);
                return result.IsSucceeded;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Удалить из БД
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        public virtual ModelEntityModifyResult Delete(int id)
        {
            try
            {
                var daoEntity = _repository.GetById(id);
                if (daoEntity == null)
                {
                    var errorData = new ErrorData(ValidatorResources.CommonErrors_EntityUpdateNotFound, new object[] { id });
                    return new ModelEntityModifyResult(errorData);
                }

                var canDeleteResult = CanDeleteInternal(daoEntity);
                if (!canDeleteResult.IsSucceeded)
                {
                    return new ModelEntityModifyResult(canDeleteResult.Errors);
                }

                _repository.Delete(id);

                _unitOfWork.Save();

                return new ModelEntityModifyResult();
            }
            catch (Exception e)
            {
                var errorData = new ErrorData(e.Message);
                return new ModelEntityModifyResult(errorData);
            }
        }

        /// <summary>
        /// Найти в БД по Id
        /// </summary>
        /// <param name="id">Id объекта</param>
        /// <returns></returns>
        public virtual TModelEntity GetById(int id)
        {
            var daoEntity = _repository.GetById(id);
            if (daoEntity == null)
            {
                return null;
            }

            return ConvertTo(daoEntity);
        }

        #endregion

        #region protected virtual

        /// <summary>
        /// Валидация сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected virtual ValidationResult ValidationInternal(TModelEntity model)
        {
            return new ValidationResult();
        }

        /// <summary>
        /// Валидация сущности при удалении
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected virtual ValidationResult CanDeleteInternal(TDaoEntity model)
        {
            return new ValidationResult();
        }

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected virtual TModelEntity ConvertTo(TDaoEntity daoEntity, TModelEntity model = null)
        {
            return Mapper.Map<TDaoEntity, TModelEntity>(daoEntity);
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected virtual TDaoEntity ConvertTo(TModelEntity model, TDaoEntity daoEntity = null)
        {
            return Mapper.Map<TModelEntity, TDaoEntity>(model);
        }

        #endregion
    }
}
