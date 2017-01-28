using System;
using System.Collections.Generic;

namespace OfflineARM.Gui.Commands
{
	/// <summary>
	/// Список команд
	/// </summary>
	public class CommandList : List<ICommand>
	{
		#region Поля
		
		/// <summary>
		/// Данные команды
		/// </summary>
		private readonly ItemData _data;
		
		/// <summary>
		/// Обработчик
		/// </summary>
		private readonly ICommandHandler _handler;
		
		/// <summary>
		/// Родительская команда
		/// </summary>
		private readonly ICommand _parentCommand;
		
		#endregion
		
		#region Конструкторы

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="handler">Обработчик добавляемых команд</param>
		public CommandList(ICommandHandler handler)
			: this(EmptyData.Value, handler)
		{
		}
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="data">Данные добавляемых команд</param>
		/// <param name="handler">Обработчик добавляемых команд</param>
		public CommandList(ItemData data, ICommandHandler handler)
		{
			this._data = data;
			this._handler = handler;
		}
			
		/// <summary>
		/// Конструктор. Используется в ICommand.ChildCommands
		/// </summary>
		/// <param name="parentCommand">Родительская команда</param>
		public CommandList(ICommand parentCommand)
		{
			this._parentCommand = parentCommand;
		}
		
		#endregion
		
		#region Добавление команд

		/// <summary>
		/// Добавляет команду
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand Add(Guid id, bool isDefault = false)
		{
			if (this._parentCommand != null)
			{
				return this.AddInternal(id, this._parentCommand.Handler, this._parentCommand.Data, isDefault);
			}
			else
			{
				return this.AddInternal(id, this._handler, this._data, isDefault);
			}
		}
		
		private ICommand AddInternal(Guid id, ICommandHandler handler, ItemData data, bool isDefault = false)
		{
			ICommand command = Command.Get(id, handler, data);
			return this.Add(command, isDefault);
		}

		/// <summary>
		/// Добавляет команду
		/// </summary>
		/// <param name="command">Команда</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand Add(ICommand command, bool isDefault)
		{
			command.IsDefault = isDefault;
			this.Add(command);
			return command;
		}

		/// <summary>
		/// Добавляет команду
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="data">Данные команды (используется для задания кастомных метаданных команды)</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand Add(Guid id, ItemData data, bool isDefault = false)
		{
			if (this._parentCommand != null)
			{
				return this.AddInternal(id, this._parentCommand.Handler, data, isDefault);
			}
			else
			{
				return this.AddInternal(id, this._handler, data, isDefault);
			}
		}
	
		#endregion
		
		#region Добавление диспетчеризованных команд

		/// <summary>
		/// Добавляет диспетчеризованную команду
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand AddDispatched(Guid id, bool isDefault = false)
		{
			if (this._parentCommand != null)
			{
				return this.AddDispatchedInternal(id, this._parentCommand.Data, isDefault, null);
			}
			else
			{
				return this.AddDispatchedInternal(id, this._data, isDefault, null);
			}
		}

		/// <summary>
		/// Добавляет диспетчеризованную команду
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="nonDispatchedHandler">Методы для вызова обработчиков в создателе команды</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand AddDispatched(Guid id, CommandHandler nonDispatchedHandler, bool isDefault = false)
		{
			if (this._parentCommand != null)
			{
				return this.AddDispatchedInternal(id, this._parentCommand.Data, isDefault, nonDispatchedHandler);
			}
			else
			{
				return this.AddDispatchedInternal(id, this._data, isDefault, nonDispatchedHandler);
			}
		}

		/// <summary>
		/// Добавляет диспетчеризованную команду
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="data">Данные команды (используется для задания кастомных метаданных команды)</param>
		/// <param name="isDefault">Флаг команды по умолчанию</param>
		/// <returns>Команда</returns>
		public ICommand AddDispatched(Guid id, ItemData data, bool isDefault = false)
		{
			return this.AddDispatchedInternal(id, data, isDefault, null);
		}

		private ICommand AddDispatchedInternal(Guid id, ItemData data, bool isDefault, CommandHandler nonDispatchedHandler)
		{
			ICommand command = DispatchedCommand.Get(id, data, nonDispatchedHandler);
			return this.Add(command, isDefault);
		}
		
		#endregion
		
		#region Добавление специальных команд
		
		/// <summary>
		/// Добавляет разделитель
		/// </summary>
		public void AddSeparator()
		{
			this.Add(CommandSeparator.Value);
		}
		
		#endregion
	}
}
