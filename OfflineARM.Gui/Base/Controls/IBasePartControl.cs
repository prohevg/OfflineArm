using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Gui.Base.Controls
{
    /// <summary>
    /// Контрол, который является частью формы или контрола
    /// </summary>
    public interface IBasePartControl : IBaseControl
    {
        /// <summary>
        /// Инициализация контрола
        /// </summary>
        void Initialization();
    }
}
