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
    }
}
