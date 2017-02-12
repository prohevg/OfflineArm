using OfflineARM.Controller.Base;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Адрес
    /// </summary>
    public interface IOrderAddressController : IBaseController
    {
        /// <summary>
        /// Адрес
        /// </summary>
        Delivery Delivery { get; set; }
    }
}
