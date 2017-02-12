using System.Windows.Forms;
using OfflineARM.Controller;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.View.Base.Views
{
    /// <summary>
    /// Базовое окно
    /// </summary>
    public class BaseView<T> : Form, IBaseView<T>
        where T : class, IBaseController
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseView()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            CreateController();
        }

        #endregion

        /// <summary>
        /// Контроллер формы
        /// </summary>
        protected T _сontroller;

        /// <summary>
        /// Контроллер для формы
        /// </summary>
        public T Controller
        {
            get
            {
                return _сontroller ?? CreateController();
            }
        }

        /// <summary>
        /// Создать контроллер для представления
        /// </summary>
        private T CreateController()
        {
            _сontroller = IoCControllers.Instance.ResolveController<T>(this);
            _сontroller.SetControllerView(this);
            return _сontroller;
        }
    }
}
