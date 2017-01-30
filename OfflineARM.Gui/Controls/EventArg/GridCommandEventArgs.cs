using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Gui.Controls.EventArg
{
    /// <summary>
    /// Действие надо строкой в гриде (добавить\удалить)
    /// </summary>
    public class GridCommandEventArgs : EventArgs
    {
        /// <summary>
        /// Строка в гриде
        /// </summary>
        public object Value
        {
            get;
            private set;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value"></param>
        public GridCommandEventArgs(object value)
        {
            this.Value = value;
        }
    }
}
