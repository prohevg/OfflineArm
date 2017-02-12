using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business.Bases;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Контрол клиент
    /// </summary>
    public interface IOrderCustomerView
    {
        /// <summary>
        /// Индекс клиета
        /// </summary>
        int SelectedIndex { get; }

        /// <summary>
        /// Адрес
        /// </summary>
        string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Список покупателей
        /// </summary>
        /// <param name="listCustomers"></param>
        void LoadCustomers(PagedResult<Customer> listCustomers);

        /// <summary>
        /// Установить выбранного покупателя
        /// </summary>
        /// <param name="customer"></param>
        void SetSelectedCustomer(Customer customer);
    }
}