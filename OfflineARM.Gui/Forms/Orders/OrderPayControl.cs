using DevExpress.Data;
using OfflineARM.Gui.Base.Controls;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public partial class OrderPayControl : BasePartControl
    {
        public OrderPayControl()
        {
            InitializeComponent();
            Initialization();
        }

        #region override

        /// <summary>
        /// Инициализация контрола
        /// </summary>
        public override void Initialization()
        {
            if (_isInitialization)
            {
                return;
            }
            _isInitialization = true;

            InitializationGridPays();
        }


        #endregion

        #region private

        /// <summary>
        /// Инициализация грида оплат
        /// </summary>
        private void InitializationGridPays()
        {
            gcPays.BeginUpdate();
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_PayType, "PayType");
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Summ, "Summ", 1, UnboundColumnType.Decimal);
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Date, "Date");
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_IsManual, "IsManual");
            gcPays.EndUpdate();
        }

        #endregion
    }
}
