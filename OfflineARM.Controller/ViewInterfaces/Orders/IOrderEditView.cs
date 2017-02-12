using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Создание\редактирование заказа
    /// </summary>
    public interface IOrderEditView : IBaseView<IOrderEditController>
    {
        /// <summary>
        /// Показать окно добавления заказа
        /// </summary>
        bool AddNewOrder();

        /// <summary>
        /// Установить ответственных
        /// </summary>
        /// <param name="allUsers">Пользователи</param>
        /// <param name="currentUser">Текущий пользователь</param>
        void LoadResponsibles(PagedResult<User> allUsers, User currentUser);

        /// <summary>
        /// Загруть и добавить в грид
        /// </summary>
        /// <param name="order">Созданый заказ</param>
        void AddToGridAndClose(Order order);
    }
}
