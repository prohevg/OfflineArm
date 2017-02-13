using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.View.Base.Views;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Форма редактирования заказа
    /// </summary>
    public partial class OrderEditView : BaseCommandView<IOrderEditController>, IOrderEditView
    {
        #region поля и свойства

        /// <summary>
        /// Спецификация
        /// </summary>
        private readonly IOrderPartSpecificView _specificView;

        /// <summary>
        /// Доставка
        /// </summary>
        private readonly IOrderPartDeliveryView _deliveryView;

        /// <summary>
        /// Оплата
        /// </summary>
        private readonly IOrderPartPayView _payView;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="specificView">Спецификация</param>
        /// <param name="deliveryView">Доставка</param>
        /// <param name="payView">Оплата</param>
        public OrderEditView(IOrderPartSpecificView specificView, IOrderPartDeliveryView deliveryView, IOrderPartPayView payView) 
        {
            InitializeComponent();
            
            this._specificView = specificView;
            this._deliveryView = deliveryView;
            this._payView = payView;

            this.tpSpecific.Controls.Add(specificView as Control);
            this.tpDelivary.Controls.Add(deliveryView as Control);
            this.tpBuy.Controls.Add(payView as Control);

            this.tcMain.SelectedPageChanged += TcMain_SelectedPageChanged;
            this.sbPrevios.Click += SbPrevios_Click;
            this.sbNext.Click += SbNext_Click;

            this.Controller.SetControllers(specificView.Controller, deliveryView.Controller, payView.Controller);

            TcMain_SelectedPageChanged(tcMain, new TabPageChangedEventArgs(tpSpecific, tpSpecific));

            this.Text = GuiResource.OrderForm_CaptionCreateOrder;
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
        }

        #endregion

        #region события

        /// <summary>
        /// След таб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbNext_Click(object sender, EventArgs e)
        {
            var current = tcMain.SelectedTabPage;
            var next = current.TabIndex == tcMain.TabPages.Count ? current : tcMain.TabPages[current.TabIndex + 1];

            tcMain.SelectedTabPage = next;
        }

        /// <summary>
        /// Пред таб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SbPrevios_Click(object sender, EventArgs e)
        {
            var current = tcMain.SelectedTabPage;
            var previos = current.TabIndex == 0 ? current : tcMain.TabPages[current.TabIndex - 1];

            tcMain.SelectedTabPage = previos;
        }

        /// <summary>
        /// Смена вкладок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TcMain_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page == tpSpecific)
            {
                sbPrevios.Visible = false;
                sbNext.Visible = true;
                sbNext.Text = tpDelivary.Text;
            }
            else if (e.Page == tpDelivary)
            {
                sbPrevios.Visible = true;
                sbNext.Visible = true;

                sbPrevios.Width = 110;

                sbPrevios.Text = tpSpecific.Text;
                sbNext.Text = tpBuy.Text;
            }
            else if (e.Page == tpBuy)
            {
                sbPrevios.Visible = true;
                sbNext.Visible = false;

                sbPrevios.Text = tpDelivary.Text;
            }
        }

        /// <summary>
        /// Смена ответственного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueResponsiable_Properties_EditValueChanged(object sender, EventArgs e)
        {
            lueResponsiable.EditValue = Controller.SetResponsable(lueResponsiable.EditValue as User);
        }

        #endregion

        #region override

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            return this.Controller.GetCommands();
        }

        #endregion

        #region IOrderEditView

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public string AmountOrder
        {
            get
            {
                return lcAmountOrder.Text;
            }
            set
            {
                lcAmountOrder.Text = value;
            }
        }

        /// <summary>
        /// Сумма оплат
        /// </summary>
        public string AmountPayments
        {
            get
            {
                return lcAmountPayment.Text;
            }
            set
            {
                lcAmountPayment.Text = value;
            }
        }

        /// <summary>
        /// Сумма остатка
        /// </summary>
        public string Balance
        {
            get
            {
                return lcBalance.Text;
            }
            set
            {
                lcBalance.Text = value;
            }
        }

        /// <summary>
        /// Показать окно добавления заказа
        /// </summary>
        public bool AddNewOrder()
        {
            return this.ShowDialog() == DialogResult.OK;
        }

        /// <summary>
        /// Установить ответственных
        /// </summary>
        /// <param name="allUsers">Пользователи</param>
        /// <param name="currentUser">Текущий пользователь</param>
        public void LoadResponsibles(PagedResult<User> allUsers, User currentUser)
        {
            this.lueResponsiable.Properties.Columns.Clear();
            this.lueResponsiable.Properties.Columns.Add(new LookUpColumnInfo("Fio", "ФИО"));
            this.lueResponsiable.Properties.DisplayMember = "Fio";

            this.lueResponsiable.Properties.DataSource = allUsers.Data;
            this.lueResponsiable.EditValue = currentUser;
        }

        /// <summary>
        /// Загруть и добавить в грид
        /// </summary>
        /// <param name="order">Созданый заказ</param>
        public void AddToGridAndClose(Order order)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
