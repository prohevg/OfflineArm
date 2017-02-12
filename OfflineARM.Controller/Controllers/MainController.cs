using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Controllers
{
    /// <summary>
    /// Контроллер главной формы
    /// </summary>
    public class MainController : BaseController, IMainController
    {
        #region поля и свойства

        /// <summary>
        /// View главной формы
        /// </summary>
        private IMainView _mainView;

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _mainView = (IMainView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {

        }

        #endregion
    }
}
