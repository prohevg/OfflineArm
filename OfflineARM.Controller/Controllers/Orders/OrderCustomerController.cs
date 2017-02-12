using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Business.Bases;
using OfflineARM.Repositories;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Контрол клиент
    /// </summary>
    public class OrderCustomerController : BaseController, IOrderCustomerController
    {
        #region поля и свойства

        /// <summary>
        /// Предстваление
        /// </summary>
        private IOrderCustomerView _orderCustomerView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderCustomerView = (IOrderCustomerView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override async void LoadView()
        {
            if (this._orderCustomerView.SelectedIndex <= 0)
            {
                var clients = await GetCustomerPrivateAsync();
                _orderCustomerView.LoadCustomers(new PagedResult<Customer>(clients.Data, clients.Paging.PageNo, clients.Paging.PageSize, clients.Paging.TotalRecordCount));
            }
            else
            {
                var clients = await GetCustomerLegalAsync();
                _orderCustomerView.LoadCustomers(new PagedResult<Customer>(clients.Data, clients.Paging.PageNo, clients.Paging.PageSize, clients.Paging.TotalRecordCount));
            }
        }

        #endregion

        #region IOrderCustomerController

        /// <summary>
        /// Покупатель
        /// </summary>
        private Customer _customer;

        /// <summary>
        /// Покупатель
        /// </summary>
        public Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }

        /// <summary>
        /// Клиенты физики
        /// </summary>
        /// <returns></returns>
        public Task<PagedResult<CustomerPrivate>> GetCustomerPrivateAsync()
        {
            var unit = new UnitOfWork();
            return unit.BusinessesRepositories.CustomerPrivateRepository.GetAllAsync();
        }

        /// <summary>
        /// Клиенты юрики
        /// </summary>
        /// <returns></returns>
        public Task<PagedResult<CustomerLegal>> GetCustomerLegalAsync()
        {
            var unit = new UnitOfWork();
            return unit.BusinessesRepositories.CustomerLegalRepository.GetAllAsync();
        }


        /// <summary>
        /// Установить клиента
        /// </summary>
        public void SetClient(Customer customer)
        {
            this._customer = customer;
            _orderCustomerView.SetSelectedCustomer(customer);

            if (customer != null)
            {
                _orderCustomerView.Address = customer.Address;
                _orderCustomerView.Phone = customer.Phone;
            }
        }

        #endregion
    }
}