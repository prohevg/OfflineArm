using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using OfflineARM.Gui.Helpers;

namespace OfflineARM.Gui.Forms.Orders
{
    public partial class OrderCustomerControl :  BasePartControl, IOrderCustomerControl
    {
        #region поля и свойства

        /// <summary>
        /// Клиент юр лицо
        /// </summary>
        private readonly ICustomerLegalImp _customerLegalImp;

        /// <summary>
        /// Клиент физ лицо
        /// </summary>
        private readonly ICustomerPrivateImp _customerPrivateImp;

        #endregion

        public OrderCustomerControl()
        {
            InitializeComponent();

            if (!DesignTimeHelper.IsInDesignMode)
            {
                _customerLegalImp = IoCBusiness.Instance.Get<ICustomerLegalImp>();
                _customerPrivateImp = IoCBusiness.Instance.Get<ICustomerPrivateImp>();
            }
        }

        #region override

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadCustomers();
        }

        #endregion

        #region Fill Customers

        /// <summary>
        /// Заполение клиентов
        /// </summary>
        private async void LoadCustomers()
        {
            this.lueCustomer.Properties.Columns.Clear();
            this.lueCustomer.Properties.Columns.Add(new LookUpColumnInfo("Name", "ФИО"));
            this.lueCustomer.Properties.Columns.Add(new LookUpColumnInfo("Phone", "Телефон"));
            this.lueCustomer.Properties.DisplayMember = "Name";

            if (this.rgCustomerType.SelectedIndex == 0)
            {
                var allCustomers = await _customerPrivateImp.GetAllAsync();
                this.lueCustomer.Properties.DataSource = allCustomers.Data.Cast<ICustomerModel>().ToList();
            }
            else
            {
                var allCustomers = await _customerLegalImp.GetAllAsync();
                this.lueCustomer.Properties.DataSource = allCustomers.Data.Cast<ICustomerModel>().ToList();
            }
        }

        /// <summary>
        /// Смена типа клиента
        /// </summary>
        private void rgClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkClient_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                if (this.rgCustomerType.SelectedIndex == 0)
                {
                    AddNewClient<ICustomerPrivateForm>(clientForm => ((ICustomerPrivateForm)clientForm).CustomerPrivate);
                }
                else
                {
                    AddNewClient<ICustomerLegalForm>(clientForm => ((ICustomerLegalForm)clientForm).CustomerLegal);
                }
            }
        }

        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        /// <typeparam name="TF">Интерфейс формы</typeparam>
        /// <param name="func">Метод, возвращающий клиента</param>
        private void AddNewClient<TF>(Func<Form, ICustomerModel> func) where TF : class
        {
            var clientForm = IoCForm.Instance.ResolveForm<TF>();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                var list = this.lueCustomer.Properties.DataSource as List<ICustomerModel> ?? new List<ICustomerModel>();

                var newCustomer = func(clientForm);
                if (newCustomer != null)
                {
                    list.Add(newCustomer);
                    this.lueCustomer.Properties.DataSource = list;
                    this.lueCustomer.EditValue = newCustomer;
                    FillSelectedCustomer();
                }
            }
        }

        /// <summary>
        /// Выбрали из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkClient_EditValueChanged(object sender, EventArgs e)
        {
            FillSelectedCustomer();
        }

        /// <summary>
        /// Выбраные клиент
        /// </summary>
        private void FillSelectedCustomer()
        {
            CustomerPrivate = this.lueCustomer.EditValue as ICustomerPrivateModel;
            if (CustomerPrivate != null)
            {
                this.teAddress.Text = CustomerPrivate.Address;
                this.tePhone.Text = CustomerPrivate.Phone;
            }

            CustomerLegal = this.lueCustomer.EditValue as ICustomerLegalModel;
            if (CustomerLegal != null)
            {
                this.teAddress.Text = CustomerLegal.Address;
                this.tePhone.Text = CustomerLegal.Phone;
            }
        }

        #endregion

        #region IOrderCustomerControl

        /// <summary>
        /// модель физ лица
        /// </summary>
        public ICustomerPrivateModel CustomerPrivate
        {
            get;
            set;
        }


        /// <summary>
        /// модель юридического лица
        /// </summary>
        public ICustomerLegalModel CustomerLegal
        {
            get;
            set;
        }

        #endregion
    }
}
