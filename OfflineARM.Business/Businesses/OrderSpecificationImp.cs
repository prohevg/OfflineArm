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
    }
}
