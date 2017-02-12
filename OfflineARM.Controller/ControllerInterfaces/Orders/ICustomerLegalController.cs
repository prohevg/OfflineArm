using System.Threading.Tasks;
using OfflineARM.Controller.Base;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Форма клиента юридического лица
    /// </summary>
    public interface ICustomerLegalController : IBaseController
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        CustomerLegal Customer { get; }

        /// <summary>
        /// Действия
        /// </summary>
        /// <returns></returns>
        Task<PagedResult<BasisAction>> GetAllActionsAsync();

        /// <summary>
        /// Сохранить нового клиента
        /// </summary>
        void SaveNewClient();
    }
}
