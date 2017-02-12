using System;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class OrderAddressController : BaseController, IOrderAddressController
    {
        #region поля и свойства

        /// <summary>
        /// View адреса
        /// </summary>
        private IOrderAddressView _orderAddressView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderAddressView = (IOrderAddressView) view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {
            
        }

        #endregion

        #region override

        /// <summary>
        /// Доставка
        /// </summary>
        private Delivery _delivery;

        /// <summary>
        /// Доставка
        /// </summary>
        public Delivery Delivery
        {
            get
            {
                if (_orderAddressView.IsSelf)
                {
                    return null;
                }

                _delivery = new Delivery()
                {
                    Guid = Guid.NewGuid(),
                    Address = _orderAddressView.Address,
                    ContactPersonName = _orderAddressView.ContactPersonName,
                    ContactPhoneMain = _orderAddressView.ContactPhoneMain,
                    ContactPhoneSecondary = _orderAddressView.ContactPhoneSecondary,
                    DeliveryDate = _orderAddressView.DeliveryDate,
                    Flat = _orderAddressView.Flat,
                    Floor = _orderAddressView.Floor,
                    Intercom = _orderAddressView.Intercom,
                    IsCargoLift = _orderAddressView.IsCargoLift,
                    IsClimb = _orderAddressView.IsClimb,
                    Porch = _orderAddressView.Porch,
                    Comment = _orderAddressView.Comment,
                };
                return _delivery;
            }
            set
            {
                _delivery = value;
            }
        }

        #endregion
    }
}
