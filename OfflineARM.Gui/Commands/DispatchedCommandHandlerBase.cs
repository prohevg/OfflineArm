namespace OfflineARM.Gui.Commands
{
	/// <summary>
	/// Базовый класс для обработчиков диспетчеризуемых команд
	/// </summary>
	/// <typeparam name="C">Тип команды</typeparam>
	public abstract class DispatchedCommandHandler<C> : ICommandHandler
		where C : DispatchedCommand
	{
		#region ICommandHandler Members

		/// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		bool ICommandHandler.CanExecute(ICommand command)
		{
			C castedCommand = command as C;
			if (castedCommand == null)
			{
				return false;
			}
			return this.CanExecute(castedCommand);
		}

		/// <summary>
		/// Действия перед выполнением команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		bool ICommandHandler.BeforeExecute(ICommand command)
		{
			C castedCommand = command as C;
			if (castedCommand == null)
			{
				return false;
			}
			return this.BeforeExecute(castedCommand);
		}

		/// <summary>
		/// Выполнение команды
		/// </summary>
		/// <param name="command">Команда</param>
		void ICommandHandler.Execute(ICommand command)
		{
			this.Execute((C)command);
		}
		
		#endregion
		
		#region Абстрактные и виртуальные методы

		/// <summary>
		/// Определяет возможность выполнения команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		protected virtual bool CanExecute(C command)
		{
			return true;
		}

		/// <summary>
		/// Действия перед выполнением команды
		/// </summary>
		/// <param name="command">Команда</param>
		/// <returns>Возможность выполнения команды</returns>
		protected virtual bool BeforeExecute(C command)
		{
			return true;
		}

		/// <summary>
		/// Выполнение команды
		/// </summary>
		/// <param name="command">Команда</param>
		protected abstract void Execute(C command);
		
		#endregion
	}
}
