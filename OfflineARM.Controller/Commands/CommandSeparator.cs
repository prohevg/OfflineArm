using System;
using System.Collections.Generic;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Разделитель команд
	/// </summary>
	public class CommandSeparator : ICommand
	{
		/// <summary>
		/// Конструктор
		/// </summary>
		private CommandSeparator()
		{
		}
		
		/// <summary>
		/// Экземпляр разделителя
		/// </summary>
		public static readonly CommandSeparator Value = new CommandSeparator();
		
		#region ICommand Members

		/// <summary>
		/// Уникальный идентификатор типа команды
		/// </summary>
		public Guid Id
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>
		/// Обработчик команды
		/// </summary>
		public ICommandHandler Handler
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		/// Данные
		/// </summary>
		public ItemData Data
		{
			get
			{
				return EmptyData.Value;
			}
		}

		/// <summary>
		/// Cостояние команды
		/// </summary>
		public CommandState State
		{
			get
			{
				return CommandState.SimpleCommandState;
			}
		}

		/// <summary>
		/// Коллекция параметров
		/// </summary>
		public Dictionary<string, object> Parameters
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		/// Дочерние команды
		/// </summary>
		public CommandList ChildCommands
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		/// Является ли командой по умолчанию
		/// </summary>
		public bool IsDefault
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		/// Определяет, может ли команда быть выполнена в данный момент
		/// </summary>
		/// <returns>true, если команда может быть выполнена, иначе false</returns>
		public bool CanExecute()
		{
			return false;
		}

		/// <summary>
		/// Выполняет команду
		/// </summary>
		/// <returns>true, если команда запускалась на обработку.
		/// false, если обработка команды была отменена</returns>
		public bool Execute()
		{
			return false;
		}

		/// <summary>
		/// Возвращает нетипизированное значение параметра
		/// </summary>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден, иначе null</returns>
		public object GetParameter(string key)
		{
			return null;
		}

		/// <summary>
		/// Возвращает типизированное значение параметра
		/// </summary>
		/// <typeparam name="T">Тип, к которому приводится значение параметра</typeparam>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден и может быть приведён к типу T, иначе default(T)</returns>
		public T GetParameter<T>(string key)
		{
			return default(T);
		}

		#endregion
	}
}
