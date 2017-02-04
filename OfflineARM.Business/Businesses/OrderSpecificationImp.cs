using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public class OrderSpecificationImp : BaseImp<IOrderSpecificationItemModel, IOrderSpecificationValidator, OrderSpecificationItem, IOrderSpecificationRepository>, IOrderSpecificationImp
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
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IOrderSpecificationItemModel ConvertTo(OrderSpecificationItem daoEntity, IOrderSpecificationItemModel model = null)
        {
            if (model == null)
            {
                model = new OrderSpecificationItemModel();
            }

            model.Id = daoEntity.Id;
            model.Guid = daoEntity.Guid;
            model.Price = daoEntity.Price;
            model.DiscountAmount = daoEntity.DiscountAmount;
            model.DiscountPercent = daoEntity.DiscountPercent;
            model.PriceWithDiscount = daoEntity.PriceWithDiscount;

            //model.Order = daoEntity.Order;
            //model.Nomenclature = daoEntity.Nomenclature;
            //model.Feature = daoEntity.Feature;

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected override OrderSpecificationItem ConvertTo(IOrderSpecificationItemModel model, OrderSpecificationItem daoEntity = null)
        {
            if (daoEntity == null)
            {
                daoEntity = new OrderSpecificationItem();
            }

            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.DiscountAmount = model.DiscountAmount;
            daoEntity.DiscountPercent = model.DiscountPercent;
            daoEntity.Price = model.Price;
            daoEntity.PriceWithDiscount = model.PriceWithDiscount;

            //daoEntity.Order = model.Order;
            //daoEntity.Nomenclature = model.Nomenclature;
            //daoEntity.Feature = model.Feature;

            return daoEntity;
        }

        #endregion
    }
}
