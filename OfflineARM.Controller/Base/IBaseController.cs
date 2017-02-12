using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Base
{
    /// <summary>
    /// Базовый контроллер для всех контролеров
    /// </summary>
    public interface IBaseController
    {
        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        void SetControllerView(IView view);

        /// <summary>
        /// Загрузка формы
        /// </summary>
        void LoadView();
    }
}
