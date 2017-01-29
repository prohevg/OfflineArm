using System;
using System.Drawing;
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
            SetMinimumSize();

            this.Text = CaptionForm;

            base.OnLoad(e);
        }

        #endregion

        #region IBaseForm

        /// <summary>
        /// Установить минимальный размер формы
        /// </summary>
        public virtual void SetMinimumSize(Size? size = null)
        {
            if (!size.HasValue)
            {
                this.MinimumSize = new Size(800, 600);
            }
            else
            {
                this.MinimumSize = size.Value;
            }
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
        DialogResult IBaseForm.ShowDialog(IBaseForm parent = null)
        {
            if (parent != null)
            {
                return this.ShowDialog(parent as BaseForm);
            }
            return this.ShowDialog();
        }

        #endregion

        #region virtual

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public virtual string CaptionForm
        {
            get;
        }

        #endregion
    }
}
