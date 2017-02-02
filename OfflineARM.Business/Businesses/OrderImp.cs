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
        /// <param name="daoEntity"></param>
        /// <returns></returns>
        protected override IOrderModel ConvertTo(Order daoEntity)
        {
            return (OrderModel)daoEntity;
        }

        /// <summary>
        /// Создание DAO сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <returns></returns>
        public override Order CreateInternal(IOrderModel model)
        {
            if (model == null)
            {
                return null;
            }

            return (Order)model;
        }

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="model">Сущность</param>
        /// <param name="daoEntity">dao Сущность</param>
        /// <returns></returns>
        public override Order UpdateDaoInternal(Order daoEntity, IOrderModel model)
        {
            daoEntity.Id = model.Id;
            daoEntity.Guid = model.Guid;
            daoEntity.Number = model.Number;
            daoEntity.DateCreate = model.DateCreate;
          //  daoEntity.Responsible = model.Responsible;
          //  daoEntity.DateShipping = model.DateShipping;
          //  daoEntity.IsSelf = model.IsSelf;
         //   daoEntity.OrderStatus = model.OrderStatus;
         //   daoEntity.Summa = model.Summa;
            return daoEntity;
        }

        #endregion
    }
}
