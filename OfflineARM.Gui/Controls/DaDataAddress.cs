using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business;
using OfflineARM.Business.Businesses.Interfaces;
using BaseControl = OfflineARM.Gui.Base.Controls.BaseControl;

namespace OfflineARM.Gui.Controls
{
    /// <summary>
    /// Поиск адреса по DaData
    /// </summary>
    public class DaDataAddress : BaseControl
    {
        #region методы

        /// <summary>
        /// Предыдущий адрес
        /// </summary>
        private string _prevAddress;

        /// <summary>
        /// Список адресов
        /// </summary>
        private readonly ListBox _listBox;

        /// <summary>
        /// Контайнер для списка адресов
        /// </summary>
        private readonly PopupContainerControl _popupControl;

        /// <summary>
        /// Редактируемое поле ввода адреса
        /// </summary>
        private readonly PopupContainerEdit _popupEdit;

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            private set;
        }

        #endregion

        #region методы

        /// <summary>
        /// Конструктор
        /// </summary>
        public DaDataAddress()
        {
            _listBox = new ListBox
            {
                Dock = DockStyle.Fill
            };
            _listBox.MouseDoubleClick += _listBox_MouseDoubleClick;

            _popupControl = new PopupContainerControl();
            _popupControl.Controls.Add(_listBox);
            
            _popupEdit = new PopupContainerEdit()
            {
                Dock = DockStyle.Fill
            };

            _popupEdit.Properties.PopupFormMinSize = _popupEdit.MinimumSize;
            _popupEdit.Properties.PopupControl = _popupControl;
            _popupEdit.Properties.TextEditStyle = TextEditStyles.Standard;
            _popupEdit.ButtonClick += DaDataAddress_ButtonClick;
            _popupEdit.QueryPopUp += _popupEdit_QueryPopUp;
            _popupEdit.Resize += _popupEdit_Resize;
            
            this.Controls.Add(_popupEdit);
        }

        #endregion

        #region события

        /// <summary>
        /// Перед открытие попапа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _popupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var address = this._popupEdit.Text;
            if (string.IsNullOrWhiteSpace(address))
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Установка ширины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _popupEdit_Resize(object sender, EventArgs e)
        {
            _popupControl.Width = _popupEdit.Width;
        }

        /// <summary>
        /// Выбор по даблклику
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetAddress();
            _popupEdit.ClosePopup();
        }

        /// <summary>
        /// Открытие списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DaDataAddress_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var address = this._popupEdit.Text;
            if (string.Equals(_prevAddress, address, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var imp = IoCBusiness.Instance.Get<IDaDataImp>();
            _listBox.DataSource = imp.GetAddress(address);

            _prevAddress = address;
        }

        #endregion
        
        #region методы

        /// <summary>
        /// Установить адрес
        /// </summary>
        private void SetAddress()
        {
            this.Address = this._listBox.Text;
            this._popupEdit.EditValue = this._listBox.Text;
        }

        #endregion
    }
}
