using System.Windows.Forms;
using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Forms.Orders.Commands
{
    /// <summary>
	/// Обработчик команды добавления заказа
	/// </summary>
	public class OrderPrintCommandHandler : DispatchedCommandHandler<DispatchedCommand>
    {
        /// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		protected override bool CanExecute(DispatchedCommand command)
        {
            return true;
        }

        /// <summary>
        /// Действия перед выполнением команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <returns>Возможность выполнения команды</returns>
        protected override bool BeforeExecute(DispatchedCommand command)
        {
            return true;
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command">Команда</param>
        protected override void Execute(DispatchedCommand command)
        {
            MessageBox.Show(((PrintData)command.Data).Test);
            // command.GetParameter<>()
        }
    }
}
