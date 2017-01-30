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
    /// Спецификация заказа
    /// </summary>
    public class OrderSpecificationImp : BaseImp<IOrderSpecificationModel, IOrderSpecificationValidator, OrderSpecification, IOrderSpecificationRepository>, IOrderSpecificationImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public OrderSpecificationImp(UnitOfWork unitOfWork, IOrderSpecificationValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.OrderSpecificationRepository, validator)
        {

        }

        #endregion

        #region IOrderSpecificationImp


        #endregion

        #region override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity"></param>
        /// <returns></returns>
        protected override IOrderSpecificationModel ConvertTo(OrderSpecification daoEntity)
        {
            var model = new OrderSpecificationModel
            {
                Id = daoEntity.Id,
                Guid = daoEntity.Guid,
                Price = daoEntity.Price,
                Count = daoEntity.Count,
                Stock = daoEntity.Stock,
                DiscountProcent = daoEntity.DiscountProcent,
                DiscountSum = daoEntity.DiscountSum,
                //TotalSum = daoEntity.TotalSum,
            };

            if (daoEntity.OrderId > 0)
            {
                model.Order = new OrderModel();

                var daoNomencl = _unitOfWork.BusinessesRepositories.OrderRepository.GetById(daoEntity.OrderId);

                model.Order.Id = daoNomencl.Id;
                //model.Nomenclature.Name = daoNomencl.Name;
            }

            if (daoEntity.NomenclatureId > 0)
            {
                model.Nomenclature = new NomenclatureModel();

                var daoNomencl =_unitOfWork.DictionaryRepositories.NomenclatureRepository.GetById(daoEntity.NomenclatureId);

                model.Nomenclature.Id = daoNomencl.Id;
                model.Nomenclature.Name = daoNomencl.Name;
            }

            if (daoEntity.CharacteristicId > 0)
            {
                model.Characteristic = new CharacteristicModel();

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
        public override OrderSpecification CreateInternal(IOrderSpecificationModel model)
        {
            if (model == null)
            {
                return null;
            }

            var result = new OrderSpecification
            {
                Id = model.Id,
                Guid = model.Guid,
                Price = model.Price,
                Count = model.Count,
                Stock = model.Stock,
                TotalSum = model.TotalSum,
                DiscountProcent = model.DiscountProcent,
                DiscountSum = model.DiscountSum
            };

            if (model.Order != null)
            {
                result.OrderId = model.Order.Id;
            }

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
        public override OrderSpecification UpdateDaoInternal(OrderSpecification daoEntity, IOrderSpecificationModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Price = model.Price;
            daoEntity.Count = model.Count;
            daoEntity.Stock = model.Stock;
            daoEntity.TotalSum = model.TotalSum;
            daoEntity.DiscountProcent = model.DiscountProcent;
            daoEntity.DiscountSum = model.DiscountSum;

            if (model.Order != null)
            {
                daoEntity.OrderId = model.Order.Id;
            }

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
