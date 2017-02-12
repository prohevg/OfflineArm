using System;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Форма создания клиента
    /// </summary>
    public class CustomerPrivateController : BaseController, ICustomerPrivateController
    {
        #region поля и свойства

        /// <summary>
        /// Форма создания клиента
        /// </summary>
        private ICustomerPrivateView _customerPrivateView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _customerPrivateView = (ICustomerPrivateView) view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region override ICustomerPrivateController

        /// <summary>
        /// Покупатель
        /// </summary>
        private CustomerPrivate _customer;

        /// <summary>
        /// Покупатель
        /// </summary>
        public CustomerPrivate Customer
        {
            get
            {
                return _customer;
            }
        }

        /// <summary>
        /// Создать нового клиента
        /// </summary>
        public void SaveNewClient()
        {
            _customer = new CustomerPrivate()
            {
                Guid = Guid.NewGuid(),
                Address = _customerPrivateView.Address,
                Name = _customerPrivateView.Name,
                Phone = _customerPrivateView.Phone,
            };
        }

        #endregion
    }
}
