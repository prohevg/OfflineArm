using System;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Business.Bases;
using OfflineARM.View.Base.Controls;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Покупатель
    /// </summary>
    public partial class OrderCustomerView :  BasePartControlView<IOrderCustomerController>, IOrderCustomerView
    {
        #region поля и свойства


        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderCustomerView()
        {
            InitializeComponent();

            Controller.LoadView();
        }

        #endregion

        #region Fill Customers

        /// <summary>
        /// Смена типа клиента
        /// </summary>
        private void rgClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.LoadView();
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
                    var customerPrivateView = IoCView.Instance.Resolve<ICustomerPrivateView>();
                    customerPrivateView.ShowDialog();
                    Controller.SetClient(customerPrivateView.Controller.Customer);
                }
                else
                {
                    var customerLegalView = IoCView.Instance.Resolve<ICustomerLegalView>();
                    customerLegalView.ShowDialog();
                    Controller.SetClient(customerLegalView.Controller.Customer);
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
            Controller.SetClient(this.lueCustomer.EditValue as Customer);
        }

        #endregion

        #region IOrderCustomerView

        /// <summary>
        /// Индекс клиета
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return this.rgCustomerType.SelectedIndex;
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
        /// Список покупателей
        /// </summary>
        /// <param name="listCustomers"></param>
        public void LoadCustomers(PagedResult<Customer> listCustomers)
        {
            this.lueCustomer.Properties.Columns.Clear();
            this.lueCustomer.Properties.Columns.Add(new LookUpColumnInfo("Name", "ФИО"));
            this.lueCustomer.Properties.Columns.Add(new LookUpColumnInfo("Phone", "Телефон"));
            this.lueCustomer.Properties.DisplayMember = "Name";

            this.lueCustomer.Properties.DataSource = listCustomers.Data;
        }

        /// <summary>
        /// Установить выбранного покупателя
        /// </summary>
        /// <param name="customer"></param>
        public void SetSelectedCustomer(Customer customer)
        {
            if (customer == null)
            {
                return;
            }

            var list = this.lueCustomer.Properties.DataSource as List<Customer> ?? new List<Customer>();
            if (!list.Contains(customer))
            {
                list.Add(customer);

                this.lueCustomer.Properties.DataSource = list;
            }

            this.lueCustomer.EditValue = customer;
        }

        #endregion
    }
}
