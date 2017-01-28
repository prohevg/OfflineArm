using System.Collections.Generic;
using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Base.Controls
{
    /// <summary>
    /// Базовый контрол с командами
    /// </summary>
    public class BaseCommandControl : BaseControl, IBaseCommandControl
    {
        #region поля и свойства

        /// <summary>
        /// Диспетчер команд
        /// </summary>
        protected CommandDispatcher _dispatcher = new CommandDispatcher();

        #endregion

        #region ICommandHandler Members

        /// <summary>
        /// Определяет возможность выполнения команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <returns>Возможность выполнения команды</returns>
        public virtual bool CanExecute(ICommand command)
        {
            bool result;
            if (!this._dispatcher.TryCanExecute(command, out result))
            {
                return true;
            }
            return result;
        }

        /// <summary>
        /// Действия перед выполнением команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <returns>Возможность выполнения команды</returns>
        public virtual bool BeforeExecute(ICommand command)
        {
            if (!this.CanExecute(command))
            {
                return false;
            }

            bool result;
            if (!this._dispatcher.TryBeforeExecute(command, out result))
            {
                return true;
            }

            return result;
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command">Команда</param>
        public virtual void Execute(ICommand command)
        {
            if (!this._dispatcher.TryExecute(command))
            {
                //if (command.Id == SaveFormCommand.ID)
                //{
                //    if (this.HasChanges)
                //    {
                //        if (this.SaveChanges())
                //        {
                //            this.RefreshForm();
                //            this.SetChangedState();
                //        }
                //    }
                //}
                //else
                //{
                //    throw new InvalidOperationException();
                //}
            }
        }

        #endregion

        #region IBaseCommandControl

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public virtual List<ICommand> GetCommands()
        {
            return new CommandList(this);
        }

        #endregion
    }
}
