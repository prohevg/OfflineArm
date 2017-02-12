namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Источник команды
	/// </summary>
	public interface ICommandHandler
	{
		/// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		bool CanExecute(ICommand command);

		/// <summary>
		/// Действия перед выполнением команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		bool BeforeExecute(ICommand command);

		/// <summary>
		/// Выполнение команды
		/// </summary>
		/// <param name="command">Команда</param>
		void Execute(ICommand command);
	}
}
