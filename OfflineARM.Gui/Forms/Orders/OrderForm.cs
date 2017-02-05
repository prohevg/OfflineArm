using System;
using OfflineARM.Gui.Base.Forms;
using OfflineARM.Gui.Commands;
using OfflineARM.Gui.Forms.Orders.Commands;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Business;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Gui.Helpers;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Форма редактирования заказа
    /// </summary>
    public partial class OrderForm : BaseCommandForm, IOrderForm
    {
        #region поля и свойства

        /// <summary>
        /// Пользователи
        /// </summary>
        private readonly IUserImp _userImp;

        /// <summary>
        /// Заказ
        /// </summary>
        private readonly IOrderImp _orderImp;

        /// <summary>
        /// Статус заказа 
        /// </summary>
        private readonly IOrderStatusImp _orderStatusImp;

        #endregion

        public OrderForm()
        {
            InitializeComponent();

            if (!DesignTimeHelper.IsInDesignMode)
            {
                _userImp = IoCBusiness.Instance.Get<IUserImp>();
                _orderImp = IoCBusiness.Instance.Get<IOrderImp>();
                _orderStatusImp = IoCBusiness.Instance.Get<IOrderStatusImp>();
            }
        }

        #region override

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadResponsables();
        }

        /// <summary>
        /// Команды для контрола
        /// </summary>
        /// <returns></returns>
        public override List<ICommand> GetCommands()
        {
            var result = new CommandList(this)
            {
                OrderCommands.Save,

            };

            result.AddDispatched(OrderCommands.OrderPrint, new PrintData());

            return result;
        }

        /// <summary>
        /// Текст заголовка формы
        /// </summary>
        public override string CaptionForm
        {
            get
            {
                return GuiResource.OrderForm_CaptionCreateOrder;
            }
        }

        /// <summary>
        /// Были ли изменения на форме
        /// </summary>
        public override bool SaveChanges()
        {
            var orderModel = new OrderModel()
            {
                Guid = Guid.NewGuid(),
                DateCreate = DateTime.Now,
                CustomerLegal = this.orderDestination.CustomerLegal,
                CustomerPrivate = this.orderDestination.CustomerPrivate,
                OrderStatus = _orderStatusImp.GetAllAsync().Result.Data.FirstOrDefault(),
                User = this.lueResponsiable.EditValue as IUserModel, 
                Specifications = this.orderSpecificControl.Specifications,
                Payments = this.orderPayControl.Payments
            };

            _orderImp.Insert(orderModel);

            return true;
        }

        #endregion

        #region Fill responsable

        /// <summary>
        /// Заполение отвественного
        /// </summary>
        private async void LoadResponsables()
        {
            this.lueResponsiable.Properties.Columns.Clear();
            this.lueResponsiable.Properties.Columns.Add(new LookUpColumnInfo("Fio", "ФИО"));

            var allUsers = await _userImp.GetAllAsync();
            this.lueResponsiable.Properties.DataSource = allUsers.Data;
            this.lueResponsiable.Properties.DisplayMember = "Fio";

            if (allUsers.Data.Count > 0)
            {
                this.lueResponsiable.EditValue = allUsers.Data[0];
            }
        }

        #endregion
    }
}
