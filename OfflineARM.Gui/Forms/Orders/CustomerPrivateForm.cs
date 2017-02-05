using System;
using System.Drawing;
using System.Windows.Forms;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    public partial class CustomerPrivateForm : BaseForm, ICustomerPrivateForm
    {
        public CustomerPrivateForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimizeBox = false;
        }

        #region override

        /// <summary>
        /// Заголовк формы
        /// </summary>
        public override string CaptionForm
        {
            get
            {
                return this.Text;
            }
        }

        /// <summary>
        /// Установить минимальный размер формы
        /// </summary>
        public override void SetMinimumSize(Size? size = null)
        {
            base.SetMinimumSize(new Size(600, 180));
        }

        #endregion

        private void sbSave_Click(object sender, System.EventArgs e)
        {
            if (CustomerPrivate == null)
            {
                CustomerPrivate = new CustomerPrivateModel()
                {
                    Guid = Guid.NewGuid()
                };
            }

            CustomerPrivate.Name = teFio.Text;
            CustomerPrivate.Address = teAddress.Text;
            CustomerPrivate.Phone = tePhone.Text;
        }

        #region IClientPrivateForm

        /// <summary>
        /// Новая модель физ лица
        /// </summary>
        public ICustomerPrivateModel CustomerPrivate
        {
            get;
            set;
        }

        #endregion
    }
}
