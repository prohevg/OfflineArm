using DevExpress.XtraEditors.Controls;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    public partial class OrderClientControl :  BasePartControl
    {
        public OrderClientControl()
        {
            InitializeComponent();
        }

        private void lkClient_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                if (this.rgClientType.SelectedIndex == 0)
                {
                    var clientForm = IoCForm.Instance.ResolveForm<IClientPrivateForm>();
                    clientForm.ShowDialog();
                }
                else
                {
                    var clientForm = IoCForm.Instance.ResolveForm<IClientOrganizationForm>();
                    clientForm.ShowDialog();
                }
            }
        }
    }
}
