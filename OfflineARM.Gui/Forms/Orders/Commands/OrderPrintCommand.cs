using System;
using System.Windows.Forms;
using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Forms.Orders.Commands
{
    /// <summary>
	/// Обработчик команды заказа
	/// </summary>
	public class OrderPrintCommand : Command
    {
        /// <summary>
		/// Уникальный идентификатор типа команды
		/// </summary>
		public static readonly Guid ID = new Guid("{5A8ADA9A-53D8-43B6-A0BC-278B28BD09B7}");

        /// <summary>
        /// Уникальный идентификатор типа команды
        /// </summary>
        public override Guid Id
        {
            get
            {
                return OrderPrintCommand.ID;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="nodeViewData">Информация об узле</param>
        public OrderPrintCommand(ItemData nodeViewData)
			: base(nodeViewData)
		{
        }
    }
}
