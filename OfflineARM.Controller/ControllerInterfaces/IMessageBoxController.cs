using OfflineARM.Controller.Base;

namespace OfflineARM.Controller.ControllerInterfaces
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public interface IMessageBoxController : IBaseController
    {
        /// <summary>
        /// Показать сообщение в диалоге
        /// </summary>
        /// <param name="message"></param>
        void Show(string message);
    }
}
