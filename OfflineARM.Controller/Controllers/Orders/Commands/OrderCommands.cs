﻿using System;
using OfflineARM.Controller.Controllers.Orders.Commands;

namespace OfflineARM.View.Forms.Orders.Commands
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

        /// <summary>
        /// Идентификатор команды сохранить 
        /// </summary>
        public static readonly Guid Save = new Guid("{2FC3EDA3-329A-4411-99CE-B2FEDBD6D69A}");

    }
}
