using OfflineARM.Controller.Base;

namespace OfflineARM.Controller.ControllerInterfaces.Settings
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    public interface ISettingApplicationController : IBaseController
    {
        /// <summary>
        /// Сохранить настройки
        /// </summary>
        void SaveSettings();
    }
}
