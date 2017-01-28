using System;

namespace OfflineARM.Gui.Commands
{
	/// <summary>
	/// Реализация абстрактного класса Command.
	/// </summary>
	internal sealed class CommandImpl : Command
	{
		/// <summary>
		/// Идентификатор команды
		/// </summary>
		private readonly Guid _id;
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="handler">Обработчик команды</param>
		internal CommandImpl(Guid id, ICommandHandler handler)
			: this(id, handler, EmptyData.Value)
		{
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="handler">Обработчик команды</param>
		/// <param name="data">Данные</param>
		internal CommandImpl(Guid id, ICommandHandler handler, ItemData data)
			: base(handler, data)
		{
			this._id = id;
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="id">Идентификатор команды</param>
		/// <param name="commandHandler">Обработчик команд</param>
		/// <param name="data">Данные узла, к которому относится команда</param>
		/// <param name="state">Состояние команды</param>
		internal CommandImpl(Guid id, ICommandHandler commandHandler, ItemData data, CommandState state)
			: base(commandHandler, data, state)
		{
			this._id = id;
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
