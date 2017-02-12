using OfflineARM.Controller.Base;
using OfflineARM.Controller.Controllers.Orders;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Контрол с вкладки доставка
    /// </summary>
    public interface IOrderPartDeliveryController : IBaseController
    {
        /// <summary>
        /// Контроллеры для вкладки доставка
        /// </summary>
        /// <param name="orderClientController">Клиент</param>
        /// <param name="orderAddressController">Адрес</param>
        void SetControllers(IOrderCustomerController orderClientController, IOrderAddressController orderAddressController);

        /// <summary>
        /// Покупатель
        /// </summary>
        CustomerLegal CustomerLegal { get; set; }

        /// <summary>
        /// Покупатель
        /// </summary>
        CustomerPrivate CustomerPrivate { get; set; }

        /// <summary>
        /// Доставка
        /// </summary>
        Delivery Delivery { get; set; }
    }
}
