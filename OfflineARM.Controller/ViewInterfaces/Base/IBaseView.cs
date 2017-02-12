using OfflineARM.Controller.Base;

namespace OfflineARM.Controller.ViewInterfaces.Base
{
    /// <summary>
    /// Базовый интерфейс окон
    /// </summary>
    public interface IBaseView<T> : IView 
        where T : IBaseController
    {
        /// <summary>
        /// Контроллер для формы
        /// </summary>
        T Controller { get; }
    }

    /// <summary>
    /// Базовый интерфейс окон
    /// </summary>
    public interface IView
    {

    }
}
