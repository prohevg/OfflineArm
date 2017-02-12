using System.Windows.Forms;
using OfflineARM.Controller;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.View.Base.Controls
{
    /// <summary>
    /// Контрол
    /// </summary>
    public class BaseControlView<T> : UserControl, IBaseView<T>
          where T : class, IBaseController
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseControlView()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        /// <summary>
        /// Контроллер формы
        /// </summary>
        private T _controller;

        /// <summary>
        /// Контроллер для формы
        /// </summary>
        public T Controller
        {
            get
            {
                return _controller ?? CreateController();
            }
        }

        /// <summary>
        /// Создать контроллер для представления
        /// </summary>
        private T CreateController()
        {
            _controller = IoCControllers.Instance.ResolveController<T>(this);
            _controller.SetControllerView(this);

            return _controller;

        }

    }
}
