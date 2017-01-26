using DevExpress.XtraBars.Ribbon;
using OfflineARM.Gui.Orders;

namespace OfflineARM.Gui
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void biOrderAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var orderForm = new OrderForm();
            orderForm.ShowInTaskbar = false;
          //  orderForm.Parent = this;
            orderForm.ShowDialog();
        }
    }
}
