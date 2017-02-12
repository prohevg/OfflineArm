using OfflineARM.Controller.Base;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Форма создания клиента
    /// </summary>
    public interface ICustomerPrivateController : IBaseController
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        CustomerPrivate Customer { get; }

        /// <summary>
        /// Создать нового клиента
        /// </summary>
        void SaveNewClient();
    }
}
