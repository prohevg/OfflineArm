using System;

namespace OfflineARM.Controller.Commands
{
	/// <summary>
	/// Реализация абстрактного класса DispatchedCommand.
	/// </summary>
	internal sealed class DispatchedCommandImpl : DispatchedCommand
	{
		/// <summary>
		/// Идентификатор команды
		/// </summary>
		private readonly Guid _id;

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		internal DispatchedCommandImpl(Guid id)
			: this(id, EmptyData.Value)
		{
		}
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="data">Данные команды</param>
		internal DispatchedCommandImpl(Guid id, ItemData data)
			: this(id, data, null)
		{
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="data">Данные команды</param>
		/// <param name="nonDispatchedHandler">Методы для вызова обработчиков в создателе команды</param>
		internal DispatchedCommandImpl(Guid id, ItemData data, CommandHandler nonDispatchedHandler)
			: base(data, nonDispatchedHandler)
		{
			this._id = id;
			this.SetHandlerType();
		}

		/// <summary>
		/// Уникальный идентификатор типа команды
		/// </summary>
		public override Guid Id
		{
			get
			{
				return this._id;
			}
		}
	}
}
