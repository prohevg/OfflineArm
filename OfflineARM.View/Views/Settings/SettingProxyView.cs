using System.Drawing;
using System.Windows.Forms;
using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View.Views.Settings
{
    /// <summary>
    /// Настройки прокси
    /// </summary>
    public partial class SettingProxyView : Form//BaseView<ISettingProxyController>
    {
        public SettingProxyView()
        {
            InitializeComponent();
            this.MinimumSize = new Size(300, 200);
        }
    }
}
