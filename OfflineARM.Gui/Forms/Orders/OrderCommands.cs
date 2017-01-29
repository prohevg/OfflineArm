using System;
using OfflineARM.Gui.Forms.Orders.Commands;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Команды для заказа
    /// </summary>
    public static class OrderCommands
    {
        /// <summary>
        /// Идентификатор команды добавления 
        /// </summary>
        public static readonly Guid OrderAdd = new Guid("{CD34CB86-653E-411B-A9DF-08AA7A2501AB}");

        /// <summary>
        /// Идентификатор команды печати
        /// </summary>
        public static readonly Guid OrderPrint = OrderPrintCommand.ID;
    }
}
