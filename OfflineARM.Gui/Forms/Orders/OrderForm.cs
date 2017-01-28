using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Форма редактирования заказа
    /// </summary>
    public partial class OrderForm : BaseForm, IOrderForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        #region override

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public override string CaptionForm
        {
            get
            {
                return GuiResource.OrderForm_CaptionCreateOrder;
            }
        }

        #endregion
    }
}
