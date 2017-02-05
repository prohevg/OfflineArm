using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class UserImp : BaseImp<IUserModel, IUserValidator, User, IUserRepository>, IUserImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public UserImp(UnitOfWork unitOfWork, IUserValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.UserRepository, validator)
        {

        }

        #endregion
    }
}
