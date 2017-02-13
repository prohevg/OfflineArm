using System;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.Controller.CustomConfigFile;
using OfflineARM.Controller.CustomConfigFile.Sections;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Settings;

namespace OfflineARM.Controller.Controllers.Settings
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    public class SettingApplicationController : BaseController, ISettingApplicationController
    {
        #region поля и свойства

        /// <summary>
        /// Представление контроллера
        /// </summary>
        private ISettingApplicationView _view;

        #endregion

        #region ISettingApplicationController

        /// <summary>
        /// Представление контроллера
        /// </summary>
        /// <param name="view"></param>
        public override void SetControllerView(IView view)
        {
            _view = (ISettingApplicationView)view;
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        public override void LoadView()
        {
            var armConfig = ConfigFileDispatcher.Instance.GetConfigFile<AppConfigFile>() ?? new AppConfigFile();
            var section = armConfig.GetSection<ArmConfigurationSection>(ArmConfigurationSection.SectionName);

            if (string.IsNullOrWhiteSpace(section.Main.PathToDocuments))
            {
                
            }

            _view.PathToDocuments = section.Main.PathToDocuments;
        }

        #endregion

        #region ISettingApplicationController

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        public void SaveSettings()
        {
            var armConfig = ConfigFileDispatcher.Instance.GetConfigFile<AppConfigFile>() ?? new AppConfigFile();
            if (armConfig == null)
            {
                throw new ArgumentNullException(ControllerResources.SettingApplicationController_ConfigFileNotFounded);
            }

            var section = armConfig.GetSection<ArmConfigurationSection>(ArmConfigurationSection.SectionName);

            section.Main.PathToDocuments = _view.PathToDocuments;

            armConfig.Save(section, ArmConfigurationSection.SectionName);
        }

        #endregion
    }
}
