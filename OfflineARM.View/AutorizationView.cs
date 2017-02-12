using System;
using System.Drawing;
using System.Windows.Forms;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class AutorizationView : BaseView<IAutorizationController>, IAutorizationView
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public AutorizationView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.MaximumSize = new Size(400, 200);
            this.MinimizeBox = this.MaximizeBox = false;
        }

        #endregion

        #region IAutorizationView

        /// <summary>
        /// Логин
        /// </summary>
        public string Login
        {
            get
            {
                return txtLogin.Text;
            }
            set
            {
                txtLogin.Text = value;
            }
        }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        /// <summary>
        /// Открыть как диалогое окно
        /// </summary>
        /// <returns></returns>
        bool IAutorizationView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK && this._сontroller.IsSuccessAutorization();
        }

        #endregion

        #region события

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Авторизоваться
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        #endregion
    }
}
