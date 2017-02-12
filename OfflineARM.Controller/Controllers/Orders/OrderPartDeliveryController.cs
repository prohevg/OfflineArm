using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Контрол с вкладки доставка
    /// </summary>
    public class OrderPartDeliveryController : BaseController, IOrderPartDeliveryController
    {
        #region поля и свойства

        /// <summary>
        /// View доставка заказа
        /// </summary>
        private IOrderPartDeliveryView _orderDeliveryView;

        /// <summary>
        /// Клиент
        /// </summary>
        private IOrderCustomerController _orderClientController;

        /// <summary>
        /// Адрес
        /// </summary>
        private IOrderAddressController _orderAddressController;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderDeliveryView = (IOrderPartDeliveryView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {
            
        }

        #endregion

        #region IOrderPartDeliveryController

        /// <summary>
        /// Покупатель
        /// </summary>
        public CustomerLegal CustomerLegal
        {
            get
            {
                return _orderClientController.Customer as CustomerLegal;
            }
            set
            {
                _orderClientController.Customer = value;
            }
        }

        /// <summary>
        /// Покупатель
        /// </summary>
        public CustomerPrivate CustomerPrivate
        {
            get
            {
                return _orderClientController.Customer as CustomerPrivate;
            }
            set
            {
                _orderClientController.Customer = value;
            }
        }

        /// <summary>
        /// Доставка
        /// </summary>
        public Delivery Delivery
        {
            get
            {
                return _orderAddressController.Delivery;
            }
            set
            {
                _orderAddressController.Delivery = value;
            }
        }

        /// <summary>
        /// Контроллеры для вкладки доставка
        /// </summary>
        /// <param name="orderClientController">Клиент</param>
        /// <param name="orderAddressController">Адрес</param>
        public void SetControllers(IOrderCustomerController orderClientController, IOrderAddressController orderAddressController)
        {
            _orderClientController = orderClientController;
            _orderAddressController = orderAddressController;
        }

        #endregion
    }
}
