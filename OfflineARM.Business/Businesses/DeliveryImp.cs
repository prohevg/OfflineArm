using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Адрес доставки в заказе
    /// </summary>
    public class DeliveryImp : BaseImp<IDeliveryModel, IDeliveryValidator, Delivery, IDeliveryRepository>, IDeliveryImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public DeliveryImp(UnitOfWork unitOfWork, IDeliveryValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.DeliveryRepository, validator)
        {

        }

        #endregion
    }
}
