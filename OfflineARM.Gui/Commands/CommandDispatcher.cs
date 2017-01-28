using System;
using System.Collections.Generic;

namespace OfflineARM.Gui.Commands
{
	/// <summary>
	/// Диспетчер команд
	/// </summary>
	public class CommandDispatcher : Dictionary<Guid, CommandHandler>
	{
		#region Методы добавления обработчиков в коллекцию
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		public void Add(Guid commandId, CommandHandler.ExecuteDelegate execute)
		{
			this.Add(commandId, new CommandHandler(execute));
		}
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		/// <param name="canExecute">Метод, определяющий, может ли быть выполнена команда</param>
		public void Add(Guid commandId, CommandHandler.ExecuteDelegate execute, 
            CommandHandler.CanExecuteDelegate canExecute)
		{
			this.Add(commandId, new CommandHandler(execute, canExecute));
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		/// <param name="beforeExecute">Метод, предваряющий выполнение команды</param>
		/// <param name="canExecute">Метод, определяющий, может ли быть выполнена команда</param>
		public void Add(Guid commandId, CommandHandler.ExecuteDelegate execute,
			CommandHandler.BeforeExecuteDelegate beforeExecute,
			CommandHandler.CanExecuteDelegate canExecute)
		{
			this.Add(commandId, new CommandHandler(execute, beforeExecute, canExecute));
		}
		
		#endregion
		
		#region Методы диспетчеризации

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.CanExecute
		/// </summary>
		/// <param name="command">Выполняемая команда</param>
		/// <param name="result">Результат вызова</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public bool TryCanExecute(ICommand command, out bool result)
		{
			return CommandHandler.TryCanExecute(this, command, out result);
		}

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.BeforeExecute
		/// </summary>
		/// <param name="command">Выполняемая команда</param>
		/// <param name="result">Результат вызова</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public bool TryBeforeExecute(ICommand command, out bool result)
		{
			return CommandHandler.TryBeforeExecute(this, command, out result);
		}

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.Execute
		/// </summary>
		/// <param name="command">Выполняемая команда</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public bool TryExecute(ICommand command)
		{
			return CommandHandler.TryExecute(this, command);
		}
		
		#endregion
	}
}