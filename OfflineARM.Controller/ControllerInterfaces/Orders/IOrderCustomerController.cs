using System.Threading.Tasks;
using OfflineARM.Controller.Base;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Business.Bases;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Контрол клиент
    /// </summary>
    public interface IOrderCustomerController : IBaseController
    {
        /// <summary>
        /// Клиенты физики
        /// </summary>
        /// <returns></returns>
        Task<PagedResult<CustomerPrivate>> GetCustomerPrivateAsync();

        /// <summary>
        /// Клиенты юрики
        /// </summary>
        /// <returns></returns>
        Task<PagedResult<CustomerLegal>> GetCustomerLegalAsync();

        /// <summary>
        /// Установить клиента
        /// </summary>
        void SetClient(Customer customer);

        /// <summary>
        /// Покупатель
        /// </summary>
        Customer Customer { get; set; }
    }
}