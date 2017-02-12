using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Форма редактирования юр лица
    /// </summary>
    public partial class CustomerLegalView : BaseView<ICustomerLegalController>, ICustomerLegalView
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public CustomerLegalView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.MinimizeBox = false;

            _сontroller.LoadView();
        }

        #endregion

        #region ICustomerLegalView

        /// <summary>
        /// Наименование
        /// </summary>
        string ICustomerLegalView.Name
        {
            get
            {
                return this.teName.Text;
            }
            set
            {
                this.teName.Text = value;
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
        /// Действующего на основании
        /// </summary>
        public BasisAction BasisAction
        {
            get
            {
                return lueOnAction.EditValue as BasisAction;
            }
            set
            {
                this.lueOnAction.EditValue = value;
            }
        }

        /// <summary>
        /// В лице
        /// </summary>
        public string Face
        {
            get
            {
                return this.teFace.Text;
            }
            set
            {
                this.teFace.Text = value;
            }
        }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position
        {
            get
            {
                return this.tePosition.Text;
            }
            set
            {
                this.tePosition.Text = value;
            }
        }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocNumber
        {
            get
            {
                return this.teDocNumber.Text;
            }
            set
            {
                this.teDocNumber.Text = value;
            }
        }

        /// <summary>
        /// От
        /// </summary>
        public DateTime DocDate
        {
            get
            {
                return this.deDocDate.DateTime;
            }
            set
            {
                this.deDocDate.DateTime = value;
            }
        }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn
        {
            get
            {
                return this.teInn.Text;
            }
            set
            {
                this.teInn.Text = value;
            }
        }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp
        {
            get
            {
                return this.teKpp.Text;
            }
            set
            {
                this.teKpp.Text = value;
            }
        }

        /// <summary>
        /// Загрузить действия
        /// </summary>
        /// <param name="listActions"></param>
        public void LoadActions(PagedResult<BasisAction> listActions)
        {
            this.lueOnAction.Properties.Columns.Clear();
            this.lueOnAction.Properties.Columns.Add(new LookUpColumnInfo("Name", "Наименование"));

            this.lueOnAction.Properties.DataSource = listActions.Data;
            this.lueOnAction.Properties.DisplayMember = "Name";
        }

        /// <summary>
        /// Открыть окно
        /// </summary>
        void ICustomerLegalView.ShowDialog()
        {
            this.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbSave_Click(object sender, System.EventArgs e)
        {
            _сontroller.SaveNewClient();
        }
    }
}
