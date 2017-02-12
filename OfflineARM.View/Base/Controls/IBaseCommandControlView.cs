using System.Collections.Generic;
using OfflineARM.Controller.Commands;

namespace OfflineARM.View.Base.Controls
{
    /// <summary>
    /// Базовый контрол с командами
    /// </summary>
    public interface IBaseCommandControlView 
    {
        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        List<ICommand> GetCommands();
    }
}
