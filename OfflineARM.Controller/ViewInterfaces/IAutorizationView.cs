using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public interface IAutorizationView : IBaseView<IAutorizationController>
    {
        /// <summary>
        /// Логин
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Открыть как диалоговое окно
        /// </summary>
        /// <returns></returns>
        bool ShowDialog();
    }
}
