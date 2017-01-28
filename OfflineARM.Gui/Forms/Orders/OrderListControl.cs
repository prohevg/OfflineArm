using System.Collections.Generic;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Список заказов
    /// </summary>
    public partial class OrderListControl : BaseCommandControl, IOrderListControl
    {
        public OrderListControl()
        {
            InitializeComponent();
        }

        #region override

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            return new CommandList(this)
            {
                OrderCommands.OrderAdd
            };
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command"></param>
        public override void Execute(ICommand command)
        {
            var orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        #endregion
    }
}
