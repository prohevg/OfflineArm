using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Business.Dictionaries
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public class OrderStatusImp : BaseImp<IOrderStatusModel, IOrderStatusValidator, OrderStatus, IOrderStatusRepository>, IOrderStatusImp
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        /// <param name="validator">Валидатор</param>
        public OrderStatusImp(UnitOfWork unitOfWork, IOrderStatusValidator validator)
            : base(unitOfWork, unitOfWork.DictionaryRepositories.OrderStatusRepository, validator)
        {

        }

        #endregion
    }
}
