using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Internal;
using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.Controller.ViewInterfaces.Settings;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View.Views.Settings
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    public partial class SettingApplicationView : BaseView<ISettingApplicationController>, ISettingApplicationView
    {
        public SettingApplicationView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MinimumSize = new Size(600, 200);
            this.MaximumSize = new Size(600, 200);

            this.bePathToDocuments.Properties.ReadOnly = true;

            this.Controller.LoadView();
        }

        #region ISettingApplicationView

        /// <summary>
        /// Путь к документам
        /// </summary>
        public string PathToDocuments
        {
            get
            {
                return this.bePathToDocuments.Text;
            }
            set
            {
                this.bePathToDocuments.Text = value;
            }
        }

        /// <summary>
        /// Открыть окно
        /// </summary>
        void ISettingApplicationView.ShowDialog()
        {
            this.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Применить настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbOk_Click(object sender, EventArgs e)
        {
            Controller.SaveSettings();
            this.Close();
        }

        /// <summary>
        /// Выбор директории для документов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePathToDocuments_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.SelectedPath = this.PathToDocuments;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    this.bePathToDocuments.EditValue = folderBrowser.SelectedPath;
                    this.Controller.SaveSettings();
                }
            }
        }
    }
}
