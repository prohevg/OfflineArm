using System;
using System.Drawing;
using System.Windows.Forms;
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
            this.MinimumSize = new Size(300, 200);

            this.bePathToDocuments.Properties.ReadOnly = true;

            this.Controller.LoadView();
        }

        /// <summary>
        /// Применить настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Controller.SaveSettings();
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
    }
}
