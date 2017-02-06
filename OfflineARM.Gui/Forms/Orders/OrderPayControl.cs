using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Data;
using OfflineARM.Business.Models.Businesses;
using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Gui.Base.Controls;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using DevExpress.XtraEditors.Controls;
using OfflineARM.Gui.Controls.EventArg;
using DevExpress.XtraEditors;

namespace OfflineARM.Gui.Forms.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public partial class OrderPayControl : BasePartControl, IOrderPayControl
    {
        #region поля и свойства

        /// <summary>
        /// Оплаты в таблице
        /// </summary>
        private readonly List<PaymentRowModel> _paymentRows = new List<PaymentRowModel>();

        #endregion

        public OrderPayControl()
        {
            InitializeComponent();
            Initialization();
        }

        #region override

        /// <summary>
        /// Инициализация контрола
        /// </summary>
        public override void Initialization()
        {
            if (_isInitialization)
            {
                return;
            }
            _isInitialization = true;

            InitializationGridPays();
            SetEnableCash(ceCashPayment.Checked);
            SetEnableCard(ceCardPayment.Checked);
            SetEnableCredit(ceCreditPayment.Checked);

            this.teCashFiscalReceipt.Enabled = false;
            this.teCardNumber.Enabled = false;
        }

        #endregion

        #region private

        /// <summary>
        /// Инициализация грида оплат
        /// </summary>
        private void InitializationGridPays()
        {
            gcPays.BeginUpdate();
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_PayType, "Type");
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Summ, "Amount", 1, UnboundColumnType.Decimal);
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Date, "PaymentDate", 2);
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_IsManual, "IsManual", 3);
            gcPays.AddColumnCommand(GuiResource.OrderPayControl_GridPayCaption_DeleteFromPays, ButtonPredefines.Delete);
            gcPays.EndUpdate();

            gcPays.OnGridCommand += gcPays_OnGridCommand;
        }

        /// <summary>
        /// Обработчик удаления из оплат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gcPays_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            var model = e.Value as PaymentRowModel;
            if (model == null)
            {
                return;
            }

            var exist = this._paymentRows.FirstOrDefault(row => row == model);
            if (exist != null)
            {
                this._paymentRows.Remove(exist);
            }

            var existPayment = this.Payments.FirstOrDefault(p => p.Guid == model.Guid);
            if (existPayment != null)
            {
                this.Payments.Remove(exist);
            }

            gcPays.DataSource = _paymentRows;
            gcPays.RefreshDataSource();

            RecalculatePayment();
        }

        /// <summary>
        /// Доступность полей ручной оплаты
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableCash(bool isEnable)
        {
            this.teCashAmount.Enabled = isEnable;
            this.teCashFiscalReceipt.Enabled = isEnable;
            this.smCashCheckManual.Enabled = isEnable;
            this.ceCashInputManual.Enabled = isEnable;

            if (isEnable)
            {
                this.teCashFiscalReceipt.Enabled = this.ceCashInputManual.Checked;
            }
        }

        /// <summary>
        /// Доступность полей оплаты картой
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableCard(bool isEnable)
        {
            this.teCardAmount.Enabled = isEnable;
            this.teCardNumber.Enabled = isEnable;
            this.ceCardManual.Enabled = isEnable;
            this.sbCardPay.Enabled = isEnable;

            if (isEnable)
            {
                this.teCardNumber.Enabled = this.ceCardManual.Checked;
            }
        }

        /// <summary>
        /// Доступность полей оплаты картой
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableCredit(bool isEnable)
        {
            this.teCreditBank.Enabled = isEnable;
            this.teCreditProgramm.Enabled = isEnable;
            this.teCreditAmount.Enabled = isEnable;
            this.teCreditBankOrderNumber.Enabled = isEnable;
            this.teCreditInitialFee.Enabled = isEnable;
            this.teCreditNameInOrder.Enabled = isEnable;
            this.meCreditScanner.Enabled = isEnable;
            this.sbCreditApply.Enabled = isEnable;
        }

        /// <summary>
        /// Привязка к таблице
        /// </summary>
        private void AddBindingPays(IPaymentModel paymentModel, bool isManual)
        {
            Payments.Add(paymentModel);

            _paymentRows.Add(new PaymentRowModel()
            {
                Id = paymentModel.Id,
                Guid = paymentModel.Guid,
                PaymentDate = paymentModel.PaymentDate,
                Type = GetPaymentType(paymentModel),
                Amount = paymentModel.Amount,
                IsManual = isManual
            });

            gcPays.DataSource = _paymentRows;
            gcPays.RefreshDataSource();

            RecalculatePayment();
        }

        /// <summary>
        /// Сумма оплат
        /// </summary>
        private void RecalculatePayment()
        {
            decimal ammount = this._paymentRows.Sum(item => item.Amount);

            lcAmountPayment.Text = string.Format("Оплачено {0} р.", ammount);
            lcBalance.Text = string.Format("Остаток {0} р.", TotalAmount - ammount);
        }

        /// <summary>
        /// Тип оплаты
        /// </summary>
        /// <param name="paymentModel"></param>
        /// <returns></returns>
        private string GetPaymentType(IPaymentModel paymentModel)
        {
            if (paymentModel is ICashPaymentModel)
            {
                return GuiResource.OrderPayControl_CashPaymentType;
            }

            if (paymentModel is ICardPaymentModel)
            {
                return GuiResource.OrderPayControl_CardPaymentType;
            }

            if (paymentModel is ICreditPaymentModel)
            {
                return GuiResource.OrderPayControl_CreditPaymentType;
            }

            throw new NotImplementedException();
        }

        #endregion

        #region события

        /// <summary>
        /// Сохранить плату нличными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smCheckManual_Click(object sender, EventArgs e)
        {
            var cashPayment = new CashPaymentModel()
            {
                Guid = Guid.NewGuid(),
                PaymentDate = DateTime.Now,
                Amount = (decimal)teCashAmount.EditValue,
                Manual = ceCashInputManual.Checked,
                FiscalReceipt = teCashFiscalReceipt.Text,
            };

            AddBindingPays(cashPayment, cashPayment.Manual);
        }

        /// <summary>
        /// Сохранить плату картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbCardPay_Click(object sender, EventArgs e)
        {
            var cardPayment = new CardPaymentModel()
            {
                Guid = Guid.NewGuid(),
                Amount = (decimal) teCardAmount.EditValue,
                CardNumber = teCardNumber.Text,
                Manual = ceCardManual.Checked,
                PaymentDate = DateTime.Now,
                RNN = teCardNumber.Text,
            };

            AddBindingPays(cardPayment, cardPayment.Manual);
        }

        /// <summary>
        /// Сохранить плату кредитом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbCreditApply_Click(object sender, EventArgs e)
        {
            var creditPayment = new CreditPaymentModel()
            {
                Guid = Guid.NewGuid(),
                Amount = (decimal)teCreditAmount.EditValue,
                PaymentDate = DateTime.Now,
                Bank = new BankModel() { Id = 1},
                BankProduct = new BankProductModel() { Id = 1 },
                BankOrderNumber = teCreditBankOrderNumber.Text,
                CreditAmount = (decimal)teCreditAmount.EditValue,
                InitialFee = (decimal)teCreditInitialFee.EditValue,
                NameInOrder = teCreditNameInOrder.Text
            };

            AddBindingPays(creditPayment, false);
        }
 
        /// <summary>
        /// Событие смены досупности оплаты налом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCashPayment_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCash(ceCashPayment.Checked);
        }

        /// <summary>
        ///  Событие смены досупности оплаты картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCardPayment_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCard(ceCardPayment.Checked);
        }

        /// <summary>
        ///  Событие смены досупности оплаты кредитом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCredit_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCredit(ceCreditPayment.Checked);
        }

        /// <summary>
        /// Вручную наличкой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCashInputManual_EditValueChanged(object sender, EventArgs e)
        {
            teCashFiscalReceipt.Enabled = (bool)((CheckEdit)sender).EditValue;
        }

        /// <summary>
        /// Вручную картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCardManual_EditValueChanged(object sender, EventArgs e)
        {
            teCardNumber.Enabled = (bool)((CheckEdit)sender).EditValue;
        }

        #endregion

        #region IOrderPayControl

        /// <summary>
        /// Оплаты
        /// </summary>
        private List<IPaymentModel> _payments = new List<IPaymentModel>();

        /// <summary>
        /// Сумма заказа
        /// </summary>
        private decimal _totalAmount;

        /// <summary>
        /// Оплаты
        /// </summary>
        public List<IPaymentModel> Payments
        {
            get
            {
                return _payments;
            }
            set
            {
                _payments = value;
            }
        }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal TotalAmount
        {
            get
            {
                return _totalAmount;
            }
            set
            {
                _totalAmount = value;
                lcAmountOrder.Text = string.Format("Итого заказа {0} р.", value);
            }
        }

        #endregion
    }
}
