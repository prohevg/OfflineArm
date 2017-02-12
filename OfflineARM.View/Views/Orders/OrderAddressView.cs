using System;
using System.Windows.Forms;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.View.Base.Controls;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Адрес доставки
    /// </summary>
    public partial class OrderAddressView : BaseControlView<IOrderAddressController>, IOrderAddressView
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderAddressView()
        {
            InitializeComponent();
        }

        #endregion

        #region IOrderAddressView

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get
            {
                return daDataAddress.Address;
            }
            set
            {
                daDataAddress.Address = value;
            }
        }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat
        {
            get
            {
                return teFlat.Text;
            }
            set
            {
                teFlat.Text = value;
            }
        }

        /// <summary>
        /// Подъезд
        /// </summary>
        public string Porch
        {
            get
            {
                return tePorch.Text;
            }
            set
            {
                tePorch.Text = value;
            }
        }

        /// <summary>
        /// Этаж
        /// </summary>
        public string Floor
        {
            get
            {
                return teFloor.Text;
            }
            set
            {
                teFloor.Text = value;
            }
        }

        /// <summary>
        /// Домон
        /// </summary>
        public string Intercom
        {
            get
            {
                return teIntercom.Text;
            }
            set
            {
                teIntercom.Text = value;
            }
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string ContactPhoneMain
        {
            get
            {
                return teContactPhoneMain.Text;
            }
            set
            {
                teContactPhoneMain.Text = value;
            }
        }

        /// <summary>
        /// Дополнительный телефон
        /// </summary>
        public string ContactPhoneSecondary
        {
            get
            {
                return teContactPhoneSecondary.Text;
            }
            set
            {
                teContactPhoneSecondary.Text = value;
            }
        }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string ContactPersonName
        {
            get
            {
                return teContactPersonName.Text;
            }
            set
            {
                teContactPersonName.Text = value;
            }
        }

        /// <summary>
        /// Наличие грузового лифта
        /// </summary>
        public bool IsCargoLift
        {
            get
            {
                return ceCargoLift.Checked;
            }
            set
            {
                ceCargoLift.Checked = value;
            }
        }

        /// <summary>
        /// Наличие подъема
        /// </summary>
        public bool IsClimb
        {
            get
            {
                return ceClimb.Checked;
            }
            set
            {
                ceClimb.Checked = value;
            }
        }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment
        {
            get
            {
                return meComment.Text;
            }
            set
            {
                meComment.Text = value;
            }
        }

        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTime DeliveryDate
        {
            get
            {
                return deDeliveryDate.DateTime;
            }
            set
            {
                deDeliveryDate.DateTime = value;
            }
        }

        /// <summary>
        /// Самовывоз
        /// </summary>
        public bool IsSelf
        {
            get
            {
                return chIsSelf.Checked;
            }
            set
            {
                chIsSelf.Checked = value;
            }
        }

        #endregion

        #region private

        private void chIsSelf_CheckedChanged(object sender, EventArgs e)
        {
            SetEnable(!chIsSelf.Checked);
        }

        private void SetEnable(bool isEnabled)
        {
            daDataAddress.Enabled = isEnabled;
            teFlat.Enabled = isEnabled;
            tePorch.Enabled = isEnabled;
            teFloor.Enabled = isEnabled;
            teIntercom.Enabled = isEnabled;
            teContactPhoneMain.Enabled = isEnabled;
            teContactPhoneSecondary.Enabled = isEnabled;
            teContactPersonName.Enabled = isEnabled;
            ceCargoLift.Enabled = isEnabled;
            ceClimb.Enabled = isEnabled;
            meComment.Enabled = isEnabled;
            deDeliveryDate.Enabled = isEnabled;
        }

        #endregion
    }
}
