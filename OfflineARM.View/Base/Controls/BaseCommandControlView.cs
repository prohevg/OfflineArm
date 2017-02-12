using System.Collections.Generic;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.Commands;

namespace OfflineARM.View.Base.Controls
{
    /// <summary>
    /// Базовый контрол с командами
    /// </summary>
    public class BaseCommandControlView<T> : BaseControlView<T>, IBaseCommandControlView
         where T : class, IBaseController
    {
        #region IBaseCommandControl

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public virtual List<ICommand> GetCommands()
        {
            return new List<ICommand>();
        }

        #endregion
    }
}
