using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders.Commands;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using System.Collections.Generic;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Форма редактирования заказа
    /// </summary>
    public partial class OrderForm : BaseCommandForm, IOrderForm
    {
        public OrderForm()
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
            var result = new CommandList(this)
            {
                OrderCommands.Save,

            };

            result.AddDispatched(OrderCommands.OrderPrint, new PrintData());

            return result;
        }

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public override string CaptionForm
        {
            get
            {
                return GuiResource.OrderForm_CaptionCreateOrder;
            }
        }

        #endregion
    }
}
