using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Клиент юр лицо
    /// </summary>
    public class CustomerLegalImp : BaseImp<ICustomerLegalModel, ICustomerLegalValidator, CustomerLegal, ICustomerLegalRepository>, ICustomerLegalImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public CustomerLegalImp(UnitOfWork unitOfWork, ICustomerLegalValidator validator)
            : base(unitOfWork, unitOfWork.BusinessesRepositories.CustomerLegalRepository, validator)
        {

        }

        #endregion
    }
}
