using System;
using System.Windows.Forms;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Адрес доставки
    /// </summary>
    public partial class OrderAddressControl : UserControl
    {
        public OrderAddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public IDeliveryModel Delivery
        {
            get
            {
                return new DeliveryModel()
                {
                    Guid = Guid.NewGuid(),
                    Address = teAddress.Text,
                    Comment = meComment.Text,
                    ContactPersonName = teContactPersonName.Text,
                    ContactPhoneMain = teContactPhoneMain.Text,
                    ContactPhoneSecondary = teContactPersonName.Text,
                    DeliveryDate = deDeliveryDate.DateTime,
                    Flat = teFloor.Text,
                    Floor = teFloor.Text,
                    Intercom = teIntercom.Text,
                    IsCargoLift = ceCargoLift.Checked,
                    IsClimb = ceClimb.Checked,
                    Porch = tePorch.Text
                };
            }
        }
    }
}
