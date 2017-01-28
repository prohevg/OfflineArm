using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
	/// Обработчик команды добавления заказа
	/// </summary>
	public class OrderAddCommandHandler : DispatchedCommandHandler<DispatchedCommand>
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
           // command.GetParameter<>()
        }
    }
}
