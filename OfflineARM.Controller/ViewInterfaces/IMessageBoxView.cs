using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public interface IMessageBoxView : IBaseView<IMessageBoxController>
    {
        /// <summary>
        /// Показать сообщение в диалоге
        /// </summary>
        /// <param name="message"></param>
        void Show(string message);
    }
}
