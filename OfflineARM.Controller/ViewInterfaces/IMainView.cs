using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public interface IMainView : IBaseView<IMainController>
    {
        /// <summary>
        /// Открыть форму
        /// </summary>
        void Show();
    }
}
