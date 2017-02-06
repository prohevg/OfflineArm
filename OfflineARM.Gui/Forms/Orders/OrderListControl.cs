using System;
using System.Collections.Generic;
using DevExpress.Data;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders.Commands;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Список заказов
    /// </summary>
    public partial class OrderListControl : BaseCommandControl, IOrderListControl
    {
        #region поля и свойства

        /// <summary>
        /// Реализация заказов
        /// </summary>
        private readonly IOrderImp _orderImp;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderListControl(IOrderImp orderImp)
        {
            _orderImp = orderImp;

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

        /// <summary>
        /// Загрузка
        /// </summary>
        private async void LoadOrders()
        {
            var paging = await _orderImp.GetAllAsync();
            gcOrders.DataSource = paging.Data;
        }

        #endregion

        #region override

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadOrders();
        }

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            var result = new CommandList(this)
            {
                OrderCommands.OrderAdd,
                
            };

            result.AddDispatched(OrderCommands.OrderPrint, new PrintData());

            return result;
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command"></param>
        public override void Execute(ICommand command)
        {
            var orderForm = IoCForm.Instance.ResolveForm<IOrderForm>();
            orderForm.ShowDialog();
            LoadOrders();
        }

        #endregion
    }
}
