using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries
{
    /// <summary>
    ///  Действующего на основании
    /// </summary>
    public class BasisActionImp : BaseImp<IBasisActionModel, IBasisActionValidator, BasisAction, IBasisActionRepository>, IBasisActionImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public BasisActionImp(UnitOfWork unitOfWork, IBasisActionValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.BasisActionRepository, validator)
        {

        }

        #endregion
    }
}
