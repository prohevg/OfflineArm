using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Контрол с вкладки доставка
    /// </summary>
    public partial class OrderDestinationControl : BasePartControl, IOrderDestinationControl
    {
        public OrderDestinationControl()
        {
            InitializeComponent();
        }

        #region IOrderCustomerControl

        /// <summary>
        /// модель физ лица
        /// </summary>
        public ICustomerPrivateModel CustomerPrivate
        {
            get
            {
                return this.orderClient.CustomerPrivate;
            }
        }

        /// <summary>
        /// модель юридического лица
        /// </summary>
        public ICustomerLegalModel CustomerLegal
        {
            get
            {
                return this.orderClient.CustomerLegal;
            }
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public IDeliveryModel Delivery
        {
            get
            {
                return this.orderAddress.Delivery;
            }
        }

        #endregion
    }
}
