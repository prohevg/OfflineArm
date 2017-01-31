using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders;

namespace OfflineARM.Gui.Base.Forms
{
    /// <summary>
    /// Базово окно с командами
    /// </summary>
    public class BaseCommandForm : BaseForm, ICommandHandler
    {
        #region поля и свойства

        /// <summary>
        /// Диспетчер команд
        /// </summary>
        protected CommandDispatcher _dispatcher = new CommandDispatcher();
        
        /// <summary>
        /// 
        /// </summary>
        protected BarManager BarManager;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseCommandForm()
        {
            InitializeComponent();

            BarCreator.CreateBars(BarManager, this.GetCommands(), item_ItemClick);
        }

        #endregion

        #region ICommandHandler Members

        /// <summary>
        /// Команды для формы
        /// </summary>
        /// <returns></returns>
        public virtual List<ICommand> GetCommands()
        {
            return new List<ICommand>();
        }

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
                if (command.Id == OrderCommands.Save)
                {
                    if (this.HasChanges)
                    {
                        if (this.SaveChanges())
                        {
                            //this.RefreshForm();
                            //this.SetChangedState();
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// Были ли изменения на форме
        /// </summary>
        public virtual bool HasChanges 
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Были ли изменения на форме
        /// </summary>
        public virtual bool SaveChanges()
        {
            return true;
        }

        /// <summary>
        /// Обработчик выполения команды пункта меню
        /// </summary>
        private void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.DoEvents();
            CommandExecutor.Execute(e.Item);
        }

        #region InitializeComponent

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        private void InitializeComponent()
        {
            BarManager = new BarManager
            {
                Form = this,
                AllowCustomization = false,
                AllowMoveBarOnToolbar = false,
                AllowQuickCustomization = false,
                AllowShowToolbarsPopup = false,
                AutoSaveInRegistry = false,
                ShowCloseButton = false,
                ShowShortcutInScreenTips = false
            };

            var bar = new Bar(BarManager)
            {
                DockStyle = BarDockStyle.Top, 
            };
        }

        #endregion
    }
}
