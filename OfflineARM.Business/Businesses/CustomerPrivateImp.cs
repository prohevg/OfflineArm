using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class CustomerPrivateImp : BaseImp<ICustomerPrivateModel, ICustomerPrivateValidator, CustomerPrivate, ICustomerPrivateRepository>, ICustomerPrivateImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public CustomerPrivateImp(UnitOfWork unitOfWork, ICustomerPrivateValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.CustomerPrivateRepository, validator)
        {

        }

        #endregion
    }
}
