using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.DAO;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Контроллер списка заказов
    /// </summary>
    public interface IOrderListView : IBaseView<IOrderListController>
    {
        /// <summary>
        /// Биндинг данных к таблице
        /// </summary>
        /// <param name="list"></param>
        void DataBindData(PagedResult<OrderRow> list);

        /// <summary>
        /// Вставить запись в в таблицу
        /// </summary>
        /// <param name="order"></param>
        void InsertToGrid(OrderRow order);
    }
}
