using System;
using System.Windows.Forms;
using OfflineARM.Controller;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;

namespace OfflineARM.View
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public class MessageBoxView : IMessageBoxView
    {
        public MessageBoxView()
        {
            Controller.SetControllerView(this);
        }

        #region IMessageBoxView

        /// <summary>
        /// Контроллер формы
        /// </summary>
        private IMessageBoxController _сontroller;

        /// <summary>
        /// Контроллер для формы
        /// </summary>
        public IMessageBoxController Controller
        {
            get
            {
                return _сontroller ?? CreateController();
            }
        }

        /// <summary>
        /// Создать контроллер для представления
        /// </summary>
        private IMessageBoxController CreateController()
        {
            _сontroller = IoCControllers.Instance.ResolveController(this);
            _сontroller.SetControllerView(this);
            return _сontroller;
        }

        /// <summary>
        /// Показать сообщение в диалоге
        /// </summary>
        /// <param name="message"></param>
        void IMessageBoxView.Show(string message)
        {
            MessageBox.Show(message, GuiResource.MessageBoxView_Error);
        }

        #endregion
    }
}
