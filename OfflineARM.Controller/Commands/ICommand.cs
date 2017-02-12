using System;
using System.Collections.Generic;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Интерфейс команды
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// Уникальный идентификатор типа команды
		/// </summary>
		Guid Id
		{
			get;
		}
		
		/// <summary>
		/// Обработчик команды
		/// </summary>
		ICommandHandler Handler
		{
			get;
		}
		
		/// <summary>
		/// Данные
		/// </summary>
		ItemData Data
		{
			get;
		}
		
		/// <summary>
		/// Cостояние команды
		/// </summary>
		CommandState State
		{
			get;
		}
		
		/// <summary>
		/// Коллекция параметров
		/// </summary>
		Dictionary<string, object> Parameters
		{
			get;
		}
		
		/// <summary>
		/// Дочерние команды
		/// </summary>
		CommandList ChildCommands
		{
			get;
		}

		/// <summary>
		/// Является ли командой по умолчанию
		/// </summary>
		bool IsDefault
		{
			get;
			set;
		}
		
		/// <summary>
		/// Определяет, может ли команда быть выполнена в данный момент
		/// </summary>
		/// <returns>true, если команда может быть выполнена, иначе false</returns>
		bool CanExecute();
		
		/// <summary>
		/// Выполняет команду
		/// </summary>
		/// <returns>true, если команда запускалась на обработку.
		/// false, если обработка команды была отменена</returns>
		bool Execute();
		
		/// <summary>
		/// Возвращает нетипизированное значение параметра
		/// </summary>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден, иначе null</returns>
		object GetParameter(string key);
		
		/// <summary>
		/// Возвращает типизированное значение параметра
		/// </summary>
		/// <typeparam name="T">Тип, к которому приводится значение параметра</typeparam>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден и может быть приведён к типу T, иначе default(T)</returns>
		T GetParameter<T>(string key);
	}
}
