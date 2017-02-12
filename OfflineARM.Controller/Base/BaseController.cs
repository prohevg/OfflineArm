using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.DAO.Entities.Business.Bases;

namespace OfflineARM.Controller.Base
{
    /// <summary>
    /// Базовый контроллер для всех контролеров
    /// </summary>
    public abstract class BaseController : IBaseController
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        Customer Customer { get; }

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
