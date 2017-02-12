using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Controllers
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public class MessageBoxController : BaseController, IMessageBoxController
    {
        #region поля и свойства

        /// <summary>
        /// View формы
        /// </summary>
        private IMessageBoxView _view;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _view = (IMessageBoxView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {

        }

        /// <summary>
        /// Показать сообщение в диалоге
        /// </summary>
        /// <param name="message"></param>
        public void Show(string message)
        {
            _view.Show(message);
        }

        #endregion

    }
}
