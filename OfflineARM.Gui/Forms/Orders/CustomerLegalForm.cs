using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Forms.Orders.Interfaces;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Форма редактирования юр лица
    /// </summary>
    public partial class CustomerLegalForm : BaseForm, ICustomerLegalForm
    {
        #region поля и свойства

        /// <summary>
        /// Пользователи
        /// </summary>
        private readonly IBasisActionImp _basisActionImp;

        #endregion

        public CustomerLegalForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimizeBox = false;

            _basisActionImp = IoCBusiness.Instance.Get<IBasisActionImp>();
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
            base.SetMinimumSize(new Size(750, 250));
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadBasicActions();
        }

        #endregion

        #region Fill LoadBasicActions

        /// <summary>
        /// Заполение отвественного
        /// </summary>
        private async void LoadBasicActions()
        {
            this.lueOnAction.Properties.Columns.Clear();
            this.lueOnAction.Properties.Columns.Add(new LookUpColumnInfo("Name", "Наименование"));

            var allUsers = await _basisActionImp.GetAllAsync();
            this.lueOnAction.Properties.DataSource = allUsers.Data;
            this.lueOnAction.Properties.DisplayMember = "Name";
        }

        #endregion

        #region ICustomerLegalForm

        /// <summary>
        /// Новая модель юридического лица
        /// </summary>
        public ICustomerLegalModel CustomerLegal
        {
            get;
            set;
        }

        #endregion

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbSave_Click(object sender, System.EventArgs e)
        {
            if (CustomerLegal == null)
            {
                CustomerLegal = new CustomerLegalModel()
                {
                    Guid = Guid.NewGuid()
                };
            }

            CustomerLegal.BasisAction = lueOnAction.EditValue as IBasisActionModel;
            CustomerLegal.DocDate = this.deDocDate.DateTime;
            CustomerLegal.DocNumber = this.teDocNumber.Text;
            CustomerLegal.Face = this.teFace.Text;
            CustomerLegal.Inn = this.teInn.Text;
            CustomerLegal.Kpp = this.teKpp.Text;
            CustomerLegal.Position = this.tePosition.Text;
            CustomerLegal.Address = this.daDataAddress.Text;
            CustomerLegal.Name = this.teName.Name;
            CustomerLegal.Phone = this.tePhone.Text;
        }
    }
}
