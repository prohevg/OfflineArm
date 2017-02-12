using System;
using System.Collections.Generic;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Обработчик команды
	/// </summary>
	public class CommandHandler
	{
		#region Делегаты

		/// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		public delegate bool CanExecuteDelegate(ICommand command);

		/// <summary>
		/// Действия перед выполнением команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		public delegate bool BeforeExecuteDelegate(ICommand command);

		/// <summary>
		/// Выполнение команды
		/// </summary>
		/// <param name="command">Команда</param>
		public delegate void ExecuteDelegate(ICommand command);

		#endregion

		#region Методы

		/// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		public readonly CanExecuteDelegate CanExecute;

		/// <summary>
		/// Действия перед выполнением команды
		/// </summary>
		public readonly BeforeExecuteDelegate BeforeExecute;

		/// <summary>
		/// Выполнение команды
		/// </summary>
		public readonly ExecuteDelegate Execute;

		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		public CommandHandler(ExecuteDelegate execute)
			: this(execute, null, null)
		{
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		/// <param name="canExecute">Метод, определяющий, может ли быть выполнена команда</param>
		public CommandHandler(ExecuteDelegate execute, CanExecuteDelegate canExecute)
			: this(execute, null, canExecute)
		{
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="execute">Метод, обрабатывающий выполнение команды</param>
		/// <param name="beforeExecute">Метод, предваряющий выполнение команды</param>
		/// <param name="canExecute">Метод, определяющий, может ли быть выполнена команда</param>
		public CommandHandler(ExecuteDelegate execute, BeforeExecuteDelegate beforeExecute,
			CanExecuteDelegate canExecute)
		{
			this.Execute = execute;
			this.BeforeExecute = beforeExecute;
			this.CanExecute = canExecute;
		}

		#endregion

		#region Методы диспетчеризации

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.CanExecute
		/// </summary>
		/// <param name="dictionary">Коллекция диспетчеров</param>
		/// <param name="command">Выполняемая команда</param>
		/// <param name="result">Результат вызова</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public static bool TryCanExecute(Dictionary<Guid, CommandHandler> dictionary,
			ICommand command, out bool result)
		{
			CommandHandler dispatcher = GetDispatcher(dictionary, command);
			if (dispatcher == null || dispatcher.CanExecute == null)
			{
				result = false;
				return false;
			}

			result = dispatcher.CanExecute(command);
			return true;
		}

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.BeforeExecute
		/// </summary>
		/// <param name="dictionary">Коллекция диспетчеров</param>
		/// <param name="command">Выполняемая команда</param>
		/// <param name="result">Результат вызова</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public static bool TryBeforeExecute(Dictionary<Guid, CommandHandler> dictionary,
			ICommand command, out bool result)
		{
			CommandHandler dispatcher = GetDispatcher(dictionary, command);
			if (dispatcher == null || dispatcher.BeforeExecute == null)
			{
				result = false;
				return false;
			}

			result = dispatcher.BeforeExecute(command);
			return true;
		}

		/// <summary>
		/// Производит попытку вызвать ICommandHandler.Execute
		/// </summary>
		/// <param name="dictionary">Коллекция диспетчеров</param>
		/// <param name="command">Выполняемая команда</param>
		/// <returns>true, если обработчик найден и вызван, иначе false</returns>
		public static bool TryExecute(Dictionary<Guid, CommandHandler> dictionary, ICommand command)
		{
			CommandHandler dispatcher = GetDispatcher(dictionary, command);
			if (dispatcher == null || dispatcher.Execute == null)
			{
				return false;
			}

			dispatcher.Execute(command);
			return true;
		}

		/// <summary>
		/// Возвращает диспетчер для команды
		/// </summary>
		/// <param name="dictionary">Коллекция диспетчеров</param>
		/// <param name="command">Выполняемая команда</param>
		/// <returns>Диспетчер, если найден</returns>
		private static CommandHandler GetDispatcher(Dictionary<Guid, CommandHandler> dictionary,
			ICommand command)
		{
			if (dictionary == null || command == null)
			{
				return null;
			}

			CommandHandler dispatcher;
			dictionary.TryGetValue(command.Id, out dispatcher);
			return dispatcher;
		}

		#endregion
	}
}
