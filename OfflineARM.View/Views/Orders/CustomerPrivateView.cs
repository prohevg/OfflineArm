using System.Windows.Forms;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View.Views.Orders
{
    public partial class CustomerPrivateView : BaseView<ICustomerPrivateController>, ICustomerPrivateView
    {
        public CustomerPrivateView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimizeBox = false;
        }

        private void sbSave_Click(object sender, System.EventArgs e)
        {
            _сontroller.SaveNewClient();
        }

        #region ICustomerPrivateView

        /// <summary>
        /// ФИО
        /// </summary>
        string ICustomerPrivateView.Name
        {
            get
            {
                return this.teFio.Text;
            }
            set
            {
                this.teFio.Text = value;
            }
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get
            {
                return this.daDataAddress.Address;
            }
            set
            {
                this.daDataAddress.Address = value;
            }
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone
        {
            get
            {
                return this.tePhone.Text;
            }
            set
            {
                this.tePhone.Text = value;
            }
        }

        /// <summary>
        /// Открыть окно
        /// </summary>
        void ICustomerPrivateView.ShowDialog()
        {
            this.ShowDialog();
        }

        #endregion
    }
}
