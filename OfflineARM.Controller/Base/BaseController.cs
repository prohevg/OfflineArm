using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Base
{
    /// <summary>
    /// Базовый контроллер для всех контролеров
    /// </summary>
    public abstract class BaseController : IBaseController
    {
        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public abstract void SetControllerView(IView view);

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public abstract void LoadView();
    }
}
