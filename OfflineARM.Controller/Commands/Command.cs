using System;
using System.Collections.Generic;
using System.Text;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.Holders;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Пользовательская команда 
	/// </summary>
	public abstract class Command : ICommand
	{
		#region Поля
		
		/// <summary>
		/// Коллекция параметров
		/// </summary>
		protected Dictionary<string, object> _parameters = new Dictionary<string, object>();
		
		/// <summary>
		/// Коллекция дочерних команд
		/// </summary>
		protected CommandList _childCommands;
		
		/// <summary>
		/// Обработчик команды
		/// </summary>
		protected ICommandHandler _commandHandler;
		
		/// <summary>
		/// Данные команды
		/// </summary>
		protected ItemData _data;
		
		/// <summary>
		/// Состояние команды
		/// </summary>
		protected CommandState _state;
		
		#endregion
		
		#region Конструкторы
		
		/// <summary>
		/// Конструктор
		/// </summary>
		protected Command()
			: this(null, EmptyData.Value)
		{
		}
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="commandHandler">Обработчик команды</param>
		protected Command(ICommandHandler commandHandler)
			: this(commandHandler, EmptyData.Value)
		{
		}
		
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="data">Данные команды</param>
        protected Command(ItemData data)
			: this (null, data)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="commandHandler">Обработчик команд</param>
        /// <param name="data">Данные узла, к которому относится команда</param>
        protected Command(ICommandHandler commandHandler, ItemData data)
        {
			this._commandHandler = commandHandler;
            this._data = data;
            this._state = CommandState.SimpleCommandState;
            this._childCommands = new CommandList(this);
        }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="commandHandler">Обработчик команд</param>
		/// <param name="data">Данные узла, к которому относится команда</param>
		/// <param name="state">Состояние команды</param>
		protected Command(ICommandHandler commandHandler, ItemData data, CommandState state)
		{
			this._commandHandler = commandHandler;
			this._data = data;
			this._state = state;
			this._childCommands = new CommandList(this);
		}
        
        #endregion
		
		#region Методы инстанцирования
		
		/// <summary>
		/// Возвращает экземпляр класса Command
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="handler">Обработчик команды</param>
		/// <returns></returns>
		public static Command Get(Guid commandId, ICommandHandler handler)
		{
			return new CommandImpl(commandId, handler);
		}

		/// <summary>
		/// Возвращает экземпляр класса Command
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="handler">Обработчик команды</param>
		/// <param name="data">Данные команды</param>
		/// <returns></returns>
		public static Command Get(Guid commandId, ICommandHandler handler, ItemData data)
		{
			return new CommandImpl(commandId, handler, data);
		}
		
		#endregion

		#region ICommand Members

		/// <summary>
		/// Уникальный идентификатор типа команды
		/// </summary>
		public abstract Guid Id
		{
			get;
		}

		/// <summary>
		/// Обработчик команды
		/// </summary>
		public ICommandHandler Handler
		{
			get
			{
				return this._commandHandler;
			}
		}
		
		/// <summary>
		/// Данные команды
		/// </summary>
		public ItemData Data
		{
			get
			{
				return this._data;
			}
		}

		/// <summary>
		/// Cостояние команды
		/// </summary>
		public CommandState State
		{
			get
			{
				return this._state;
			}
		}

		/// <summary>
		/// Коллекция параметров
		/// </summary>
		public Dictionary<string, object> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		/// <summary>
		/// Дочерние команды
		/// </summary>
		public CommandList ChildCommands
		{
			get
			{
				return this._childCommands;
			}
		}

		/// <summary>
		/// Является ли командой по умолчанию
		/// </summary>
		public bool IsDefault
		{
			get;
			set;
		}

		/// <summary>
		/// Определяет, может ли команда быть выполнена в данный момент
		/// </summary>
		/// <returns>true, если команда может быть выполнена, иначе false</returns>
		public virtual bool CanExecute()
		{
			return this._commandHandler.CanExecute(this);
		}

		/// <summary>
		/// Выполняет команду
		/// </summary>
		/// <returns>true, если команда запускалась на обработку.
		/// false, если обработка команды была отменена</returns>
		public virtual bool Execute()
		{
			bool result = this._commandHandler.BeforeExecute(this);
			if (result)
			{
				this._commandHandler.Execute(this);
			}
			return result;
		}

		/// <summary>
		/// Возвращает нетипизированное значение параметра
		/// </summary>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден, иначе null</returns>
		public object GetParameter(string key)
		{
			object value;
			if (this._parameters.TryGetValue(key, out value))
			{
				return value;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Возвращает типизированное значение параметра
		/// </summary>
		/// <typeparam name="T">Тип, к которому приводится значение параметра</typeparam>
		/// <param name="key">Ключ параметра</param>
		/// <returns>Значение параметра, если он найден и может быть приведён к типу T, иначе default(T)</returns>
		public T GetParameter<T>(string key)
		{
			object value;
			if (this._parameters.TryGetValue(key, out value))
			{
				if (value is T)
				{
					return (T)value;
				}
			}
			return default(T);
		}

		#endregion
		
		#region ToString
		
		/// <summary>
		/// Возвращает строковое представление команды
		/// </summary>
		/// <returns>Строковое представление команды</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			ICommandMetadataBase md = CommandMetadataHolderBase.Instance.GetMetadata(this.Id);
			if (md != null)
			{
				sb.Append(md.Caption).Append(", ");
			}
			else
			{
				sb.Append("Id = ");
			}
			
			sb.Append(this.Id);
			return sb.ToString();
		}
		
		#endregion
	}
}
