using System.Collections.Generic;
using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Base.Controls
{
    /// <summary>
    /// Базовый контрол с командами
    /// </summary>
    public interface IBaseCommandControl : ICommandHandler
    {
        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        List<ICommand> GetCommands();
    }
}
