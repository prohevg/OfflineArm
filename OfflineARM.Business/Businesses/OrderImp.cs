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
    /// Заказ
    /// </summary>
    public class OrderImp : BaseImp<IOrderModel, IOrderValidator, Order, IOrderRepository>, IOrderImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public OrderImp(UnitOfWork unitOfWork, IOrderValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.OrderRepository, validator)
        {

        }

        #endregion

        #region IOrderImp


        #endregion

        #region override

        /// <summary>
        /// Метод конвертации Dao объектa в бизнес-модель 
        /// </summary>
        /// <param name="daoEntity">dao Сущность</param>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        protected override IOrderModel ConvertTo(Order daoEntity, IOrderModel model = null)
        {
            if (model == null)
            {
                model = new OrderModel();
            }

            model.Id = daoEntity.Id;
            model.Guid = daoEntity.Guid;
            model.DateCreate = daoEntity.DateCreate;
            model.Number = daoEntity.Number;
           


            //model.OrderStatus = daoEntity.OrderStatus;

            return model;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">Существующая dao сущность</param>
        /// <returns></returns>
        protected override Order ConvertTo(IOrderModel model, Order daoEntity = null)
        {
            if (daoEntity == null)
            {
                daoEntity = new Order();
            }

            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.DateCreate = model.DateCreate;
            daoEntity.Number = model.Number;

           

            return daoEntity;
        }

        #endregion
    }
}
