using DevExpress.XtraBars;

namespace OfflineARM.Gui.Commands
{
    /// <summary>
	/// Запускает команду на выполнение, преобразуя при необходимости её состояние
	/// </summary>
	public static class CommandExecutor
    {
        /// <summary>
        /// Запускает команду на выполнение, преобразуя при необходимости её состояние
        /// </summary>
        /// <param name="commandItem"></param>
        public static void Execute(BarItem commandItem)
        {
            ICommand command = (ICommand)commandItem.Tag;
            command.Execute();
        }
    }
}
