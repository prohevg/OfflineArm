using System;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.Holders;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Базовый класс для всех команд, чей реальный обработчик доступен по записи в холдере
	/// DispatchedCommandHolder
	/// </summary>
	public abstract class DispatchedCommand : Command
	{
		#region Поля
		
		/// <summary>
		/// Методы для вызова обработчиков в создателе команды
		/// </summary>
		protected CommandHandler _nonDispatchedHandler;
		
		#endregion
		
		#region Конструкторы

		/// <summary>
		/// Конструктор
		/// </summary>
		protected DispatchedCommand()
			: this(EmptyData.Value, null)
		{
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="data">Данные команды</param>
		protected DispatchedCommand(ItemData data)
			: this(data, null)
		{
		}
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="data">Данные команды</param>
		/// <param name="nonDispatchedHandler">Методы для вызова обработчиков в создателе команды</param>
		protected DispatchedCommand(ItemData data, CommandHandler nonDispatchedHandler)
			: base(data)
		{
			if (this.Id != Guid.Empty)
			{
				this.SetHandlerType();
			}
			this._nonDispatchedHandler = nonDispatchedHandler;
		}
		
		/// <summary>
		/// Устанавливает обработчик команды
		/// </summary>
		protected void SetHandlerType()
		{
			Type handlerType = DispatchedCommandHolder.Instance.GetType(this.Id);
			if (handlerType != null)
			{
				this._commandHandler = (ICommandHandler)Activator.CreateInstance(handlerType);
			}
		}

		/// <summary>
		/// Определяет, может ли команда быть выполнена в данный момент
		/// </summary>
		/// <returns>true, если команда может быть выполнена, иначе false</returns>
		public override bool CanExecute()
		{
			if (!this.IsCommandAvailable())
			{
				return false;
			}
			if (this._nonDispatchedHandler != null && this._nonDispatchedHandler.CanExecute != null &&
				!this._nonDispatchedHandler.CanExecute(this))
			{
				return false;
			}
			return this._commandHandler.CanExecute(this);
		}


		/// <summary>
		/// Выполняет команду
		/// </summary>
		public override bool Execute()
		{
			if (!this.IsCommandAvailable())
			{
				return false;
			}
			if (this._nonDispatchedHandler != null && this._nonDispatchedHandler.BeforeExecute != null &&
				!this._nonDispatchedHandler.BeforeExecute(this))
			{
				return false;
			}
			if (!this._commandHandler.BeforeExecute(this))
			{
				return false;
			}
			
			if (this._nonDispatchedHandler != null && this._nonDispatchedHandler.Execute != null)
			{
				this._nonDispatchedHandler.Execute(this);
			}
			
			this._commandHandler.Execute(this);
			return true;
		}

		/// <summary>
		/// Проверяет возможность выполнения команды
		/// </summary>
		/// <returns>Возможность выполнения команды</returns>
		private bool IsCommandAvailable()
		{
			return this._commandHandler != null;
		}
		
		#endregion

		#region Методы инстанцирования

		/// <summary>
		/// Возвращает экземпляр класса DispatchedCommand
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <returns></returns>
		public static DispatchedCommand Get(Guid commandId)
		{
			return new DispatchedCommandImpl(commandId);
		}

		/// <summary>
		/// Возвращает экземпляр класса Command
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="data">Данные команды</param>
		/// <returns></returns>
		public static DispatchedCommand Get(Guid commandId, ItemData data)
		{
			return new DispatchedCommandImpl(commandId, data);
		}

		/// <summary>
		/// Возвращает экземпляр класса Command
		/// </summary>
		/// <param name="commandId">Идентификатор команды</param>
		/// <param name="data">Данные команды</param>
		/// <param name="nonDispatchedHandler">Методы для вызова обработчиков в создателе команды</param>
		/// <returns></returns>
		public static DispatchedCommand Get(Guid commandId, ItemData data, CommandHandler nonDispatchedHandler)
		{
			return new DispatchedCommandImpl(commandId, data, nonDispatchedHandler);
		}

		#endregion

	}
}
