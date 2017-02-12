using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Форма создания клиента
    /// </summary>
    public interface ICustomerPrivateView : IBaseView<ICustomerPrivateController>
    {
        /// <summary>
        /// ФИО
        /// </summary>
        string Name
        {
            get;
            set;
        }

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
        /// Открыть окно
        /// </summary>
        void ShowDialog();
    }
}
