using System.Collections.Generic;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.Controller.Controllers.Settings.Commands;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Settings;

namespace OfflineARM.Controller.Controllers.Settings
{
    /// <summary>
    /// Главный контрол таба настройки
    /// </summary>
    public class SettingsController : BaseCommandController, ISettingsController
    {
        #region поля и свойства

        /// <summary>
        /// View для контролера
        /// </summary>
        private ISettingsView _view;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _view = (ISettingsView)view;
        }

        /// <summary>
        /// Загрузить данные
        /// </summary>
        public override void LoadView()
        {

        }

        #endregion

        #region IBaseCommandControl

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            var result = new CommandList(this)
            {
                SettingsCommands.ApplicationSettings,
            };

            return result;
        }

        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="command">Команда</param>
        public override void Execute(ICommand command)
        {
            if (command.Id == SettingsCommands.ApplicationSettings)
            {
                OpenApplicationSettings();
            }
        }

        /// <summary>
        /// Открыть настройки приложения
        /// </summary>
        private void OpenApplicationSettings()
        {
            var applicationView = IoCControllers.Instance.Get<ISettingApplicationView>();
            applicationView.ShowDialog();
        }

        #endregion
    }
}
