using System.Drawing;
using System.Windows.Forms;
using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    public partial class ClientPrivateForm : BaseForm, IClientPrivateForm
    {
        public ClientPrivateForm()
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
    }
}
