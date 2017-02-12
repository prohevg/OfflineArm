using OfflineARM.Controller.Base;

namespace OfflineARM.View.Base.Controls
{
    /// <summary>
    /// Контрол, который является частью формы или контрола
    /// </summary>
    public class BasePartControlView<T> : BaseControlView<T>, IBasePartControlView
         where T : class, IBaseController
    {
        #region поля и свойства

        /// <summary>
        /// true - Если форма инициализирована
        /// </summary>
        protected bool _isInitialization;

        #endregion

        #region IBasePartControl

        /// <summary>
        /// Инициализация контрола
        /// </summary>
        public virtual void Initialization()
        {
            _isInitialization = true;
        }

        #endregion
    }
}
