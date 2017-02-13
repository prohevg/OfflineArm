using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces.Settings
{
    /// <summary>
    /// Представление настроек приложения
    /// </summary>
    public interface ISettingApplicationView : IBaseView<ISettingApplicationController>
    {
        /// <summary>
        /// Путь к документам
        /// </summary>
        string PathToDocuments { get; set; }

        /// <summary>
        /// Открыть окно
        /// </summary>
        void ShowDialog();
    }
}
