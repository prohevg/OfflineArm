using System;
using System.Windows.Forms;

namespace OfflineARM.Gui.Base.Forms
{
    /// <summary>
    /// Базовое окно
    /// </summary>
    public class BaseForm : Form, IBaseForm
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseForm()
        {
           
        }

        #endregion

        #region события

        /// <summary>
        /// Загрузка окна
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            SetCaptionForm();
            base.OnLoad(e);
        }

        #endregion

        #region IBaseForm

        /// <summary>
        /// Установить заголовок формы
        /// </summary>
        public void SetCaptionForm()
        {
            this.Text = CaptionForm;
        }

        /// <summary>
        /// Открыть окно
        /// </summary>
        /// <returns></returns>
        void IBaseForm.Show()
        {
            this.Show();
        }

        /// <summary>
        /// Открыть как диалоговое окно
        /// </summary>
        /// <returns></returns>
        DialogResult IBaseForm.ShowDialog()
        {
            return this.ShowDialog();
        }

        #endregion

        #region virtual

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public virtual string CaptionForm { get; }

        #endregion
    }
}
