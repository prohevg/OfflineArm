using OfflineARM.Controller.ViewInterfaces;

namespace OfflineARM.Controller.Commands
{
    /// <summary>
	/// Запускает команду на выполнение, преобразуя при необходимости её состояние
	/// </summary>
	public static class CommandExecutor
    {
        /// <summary>
        /// Запускает команду на выполнение, преобразуя при необходимости её состояние
        /// </summary>
        /// <param name="command"></param>
        public static void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
