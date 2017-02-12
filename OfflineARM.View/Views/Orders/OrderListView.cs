using System.Collections.Generic;
using DevExpress.Data;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.View.Base.Controls;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Models.Orders;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Список заказов
    /// </summary>
    public partial class OrderListView : BaseCommandControlView<IOrderListController>, IOrderListView
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderListView()
        {
            InitializeComponent();
            InitializationGridOrders();
        }

        #endregion

        #region Fill Grid

        /// <summary>
        /// Создание столюцов таблицы экспозиции
        /// </summary>
        private void InitializationGridOrders()
        {
            gcOrders.GridView.OptionsView.ShowAutoFilterRow = true;
            gcOrders.BeginUpdate();
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_Number, "Number");
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_DateCreate, "DateCreate", 1);
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_User, "User.Fio", 2);
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_Customer, "Customer.Name", 3);
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_DelivaryDate, "Delivery.DeliveryDate", 4);
            gcOrders.AddColumn(GuiResource.OrderListControl_GridOrderCaption_TotalAmount, "TotalAmount", 5, UnboundColumnType.Decimal);
            gcOrders.EndUpdate();
        }

        #endregion

        #region IOrderListView

        /// <summary>
        /// Биндинг данных к таблице
        /// </summary>
        /// <param name="list"></param>
        public void DataBindData(PagedResult<OrderRow> list)
        {
            gcOrders.DataSource = list.Data;
        }

        /// <summary>
        /// Вставить запись в в таблицу
        /// </summary>
        /// <param name="order"></param>
        public void InsertToGrid(OrderRow order)
        {
            var list = gcOrders.DataSource as List<OrderRow>;
            if (list != null)
            {
                list.Insert(0, order);
                gcOrders.DataSource = list;
                gcOrders.RefreshDataSource();
            }
        }

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            return Controller.GetCommands();
        }

        #endregion
    }
}
