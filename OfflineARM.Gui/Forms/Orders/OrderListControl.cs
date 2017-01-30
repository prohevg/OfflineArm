using System.Collections.Generic;
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
        /// Форма заказа
        /// </summary>
        private readonly IOrderForm _orderForm;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderListControl(IOrderForm orderForm)
        {
            _orderForm = orderForm;
            InitializeComponent();
        }

        #endregion

        #region override

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
            _orderForm.ShowDialog();
        }

        #endregion
    }
}
