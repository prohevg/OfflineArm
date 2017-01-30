using System;
using System.Windows.Forms;
using OfflineARM.Business.Autorizations;
using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Interfaces.Windows;
using System.Drawing;

namespace OfflineARM.Gui
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class LoginForm : BaseFormDisableResize, ILoginForm
    {
        #region поля и свойства

        /// <summary>
        /// Реализация авторизации
        /// </summary>
        private readonly IAutorizationImp _autorizationImp;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="autorizationImp">Реализация авторизации</param>
        public LoginForm(IAutorizationImp autorizationImp)
        {
            InitializeComponent();

            _autorizationImp = autorizationImp;

#if DEBUG
            txtLogin.Text = "admin";
            txtPassword.Text = "admin";
#endif
        }

        #endregion

        #region ILoginForm

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public override string CaptionForm
        {
            get
            {
                return GuiResource.LoginForm_Caption;
            }
        }

        /// <summary>
        /// Установить минимальный размер формы
        /// </summary>
        public override void SetMinimumSize(Size? size = null)
        {
            size = new Size(400, 200);
            this.ClientSize = size.Value;
            this.MaximumSize = size.Value;
            this.MinimumSize = size.Value;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {
            if (!_autorizationImp.IsSuccessAutorization(txtLogin.Text, txtPassword.Text))
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
