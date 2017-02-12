using System;
using System.Collections.Generic;
using DevExpress.Data;
using OfflineARM.View.Base.Controls;
using DevExpress.XtraEditors.Controls;
using OfflineARM.View.Controls.EventArg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.Controller.ParsingCodes;
using OfflineARM.Controller.ViewInterfaces.Orders;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public partial class OrderPartPayView : BasePartControlView<IOrderPartPayController>, IOrderPartPayView
    {
        #region поля и свойства

        /// <summary>
        /// Правило - поле не должно быть пустым
        /// </summary>
        private ConditionValidationRule _vrNotEmpty;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderPartPayView()
        {
            InitializeComponent();
            Initialization();
            InitializationValidators();
        }

        #endregion

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

            Controller.LoadView();
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
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Date, "PaymentDate", 1, UnboundColumnType.DateTime, 100);
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_Summ, "Amount", 2, UnboundColumnType.Decimal, 120);
            gcPays.AddColumn(GuiResource.OrderPayControl_GridPayCaption_IsManual, "IsManual", 3, width: 50);
            gcPays.AddColumnCommand(GuiResource.OrderPayControl_GridPayCaption_DeleteFromPays, ButtonPredefines.Delete, 4, 100);
            gcPays.EndUpdate();

            gcPays.OnGridCommand += gcPays_OnGridCommand;
        }

        /// <summary>
        /// Валидация контролов
        /// </summary>
        private void InitializationValidators()
        {
            _vrNotEmpty = new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.NotEquals,
                Value1 = "",
            };

            creditValidationProvider.SetValidationRule(teCreditBank, _vrNotEmpty);
            creditValidationProvider.SetValidationRule(teCreditBankProduct, _vrNotEmpty);
            creditValidationProvider.SetValidationRule(teCreditNameInOrder, _vrNotEmpty);
            creditValidationProvider.SetValidationRule(teCreditAmount, _vrNotEmpty);
            creditValidationProvider.SetValidationRule(teCreditInitialFee, _vrNotEmpty);
            creditValidationProvider.SetValidationRule(teCreditBankOrderNumber, _vrNotEmpty);

            cashValidationProvider.SetValidationRule(teCashAmount, _vrNotEmpty);

            cardValidationProvider.SetValidationRule(teCardAmount, _vrNotEmpty);
        }

        /// <summary>
        /// Обработчик удаления из оплат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gcPays_OnGridCommand(object sender, GridCommandEventArgs e)
        {
            Controller.RemoveFromPayment(e.Value as PaymentRow);
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
            this.ceCardInputManual.Enabled = isEnable;
            this.sbCardPay.Enabled = isEnable;

            if (isEnable)
            {
                this.teCardNumber.Enabled = this.ceCardInputManual.Checked;
            }
        }

        /// <summary>
        /// Доступность полей оплаты картой
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableCredit(bool isEnable)
        {
            this.teCreditBank.Enabled = isEnable;
            this.teCreditBankProduct.Enabled = isEnable;
            this.teCreditAmount.Enabled = isEnable;
            this.teCreditBankOrderNumber.Enabled = isEnable;
            this.teCreditInitialFee.Enabled = isEnable;
            this.teCreditNameInOrder.Enabled = isEnable;
            this.meCreditScanner.Enabled = isEnable;
            this.sbCreditApply2.Enabled = isEnable;
        }

        /// <summary>
        /// Значение
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private decimal GetValue(object value)
        {
            return value != null ? decimal.Parse(value.ToString()) : 0;
        }

        #endregion

        #region события

        /// <summary>
        /// Сохранить плату нличными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbCheckManual_Click(object sender, EventArgs e)
        {
            if (!cashValidationProvider.Validate())
            {
                return;
            }

            Controller.AddNewCashPayment();
        }

        /// <summary>
        /// Сохранить плату картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbCardPay_Click(object sender, EventArgs e)
        {
            if (!cardValidationProvider.Validate())
            {
                return;
            }

            Controller.AddNewCardPayment();
        }

        /// <summary>
        /// Сохранить плату кредитом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbCreditApply_Click(object sender, EventArgs e)
        {
            if (!creditValidationProvider.Validate())
            {
                return;
            }

            Controller.AddNewCreditPayment();
        }
 
        /// <summary>
        /// Событие смены досупности оплаты налом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCashPayment_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCash(ceCashPayment.Checked);

            if (!ceCashPayment.Checked)
            {
                cashValidationProvider.ResetValidate();
                cashValidationProvider.RemoveControl(teCashFiscalReceipt);
            }
        }

        /// <summary>
        ///  Событие смены досупности оплаты картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCardPayment_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCard(ceCardPayment.Checked);

            if (!ceCashPayment.Checked)
            {
                cashValidationProvider.ResetValidate();
            }
        }

        /// <summary>
        ///  Событие смены досупности оплаты кредитом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCredit_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableCredit(ceCreditPayment.Checked);

            if (!ceCashPayment.Checked)
            {
                cashValidationProvider.ResetValidate();
            }
        }

        /// <summary>
        /// Вручную наличкой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCashInputManual_EditValueChanged(object sender, EventArgs e)
        {
            teCashFiscalReceipt.Enabled = (bool)((CheckEdit)sender).EditValue;

            if (teCashFiscalReceipt.Enabled)
            {
                cashValidationProvider.SetValidationRule(teCashFiscalReceipt, _vrNotEmpty);
            }
            else
            {
                cashValidationProvider.RemoveControl(teCashFiscalReceipt);
            }
        }

        /// <summary>
        /// Вручную картой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ceCardManual_EditValueChanged(object sender, EventArgs e)
        {
            teCardNumber.Enabled = (bool)((CheckEdit)sender).EditValue;

            if (teCardNumber.Enabled)
            {
                cardValidationProvider.SetValidationRule(teCardNumber, _vrNotEmpty);
            }
            else
            {
                cardValidationProvider.RemoveControl(teCardNumber);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbReadCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(meCreditScanner.Text))
            {
                XtraMessageBox.Show(GuiResource.OrderPayControl_InputCodeIsNull);
            }

            try
            {
                Controller.ParseCode();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region IOrderPartPayView

        /// <summary>
        /// Сумма наличными
        /// </summary>
        public decimal CashAmount
        {
            get
            {
                return GetValue(teCashAmount.EditValue);
            }
            set
            {
                teCashAmount.EditValue = value;
            }
        }

        /// <summary>
        /// Номер чека
        /// </summary>
        public string CashFiscalReceipt
        {
            get
            {
                return teCashFiscalReceipt.Text;
            }
            set
            {
                teCashFiscalReceipt.Text = value;
            }
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        public bool CashInputManual
        {
            get
            {
                return ceCashInputManual.Checked;
            }
            set
            {
                ceCashInputManual.Checked = value;
            }
        }

        /// <summary>
        /// Сумма картой
        /// </summary>
        public decimal CardAmount
        {
            get
            {
                return GetValue(teCardAmount.EditValue);
            }
            set
            {
                teCardAmount.EditValue = value;
            }
        }

        /// <summary>
        /// Номер карты
        /// </summary>
        public string CardNumber
        {
            get
            {
                return teCardNumber.Text;
            }
            set
            {
                teCardNumber.Text = value;
            }
        }

        /// <summary>
        /// Оплата в ручную
        /// </summary>
        public bool CardInputManual
        {
            get
            {
                return ceCardInputManual.Checked;
            }
            set
            {
                ceCardInputManual.Checked = value;
            }
        }

        /// <summary>
        /// Банк
        /// </summary>
        public string CreditBank
        {
            get
            {
                return teCreditBank.Text;
            }
            set
            {
                teCreditBank.Text = value;
            }
        }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        public string CreditBankProduct
        {
            get
            {
                return teCreditBankProduct.Text;
            }
            set
            {
                teCreditBankProduct.Text = value;
            }
        }

        /// <summary>
        /// № договора
        /// </summary>
        public string CreditBankOrderNumber
        {
            get
            {
                return teCreditBankOrderNumber.Text;
            }
            set
            {
                teCreditBankOrderNumber.Text = value;
            }
        }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        public decimal CreditAmount
        {
            get
            {
                return GetValue(teCreditAmount.EditValue);
            }
            set
            {
                teCreditAmount.EditValue = value;
            }
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        public decimal CreditInitialFee
        {
            get
            {
                return GetValue(teCreditInitialFee.EditValue);
            }
            set
            {
                teCreditInitialFee.EditValue = value;
            }
        }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string CreditNameInOrder
        {
            get
            {
                return teCreditNameInOrder.Text;
            }
            set
            {
                teCreditNameInOrder.Text = value;
            }
        }

        /// <summary>
        /// Штрих код кредита
        /// </summary>
        public string CreditScannerCode
        {
            get
            {
                return teCreditScanner.Text;
            }
            set
            {
                teCreditScanner.Text = value;
            }
        }

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
        /// Добавить в таблицу оплат
        /// </summary>
        /// <param name="paymentRow">Оплата</param>
        public void AddPaymentToGrid(PaymentRow paymentRow)
        {
            if (paymentRow == null)
            {
                return;
            }

            var list = gcPays.DataSource as List<PaymentRow> ?? new List<PaymentRow>();

            list.Add(paymentRow);

            gcPays.DataSource = list;
            gcPays.RefreshDataSource();
        }

        /// <summary>
        /// Удалить из таблицы оплат
        /// </summary>
        /// <param name="paymentRow">Оплата</param>
        public void RemovePaymentFromGrid(PaymentRow paymentRow)
        {
            if (paymentRow == null || gcPays.DataSource == null)
            {
                return;
            }

            var list = gcPays.DataSource as List<PaymentRow>;
            if (list == null)
            {
                return;
            }

            list.Remove(paymentRow);

            gcPays.DataSource = list;
            gcPays.RefreshDataSource();
        }

        #endregion
    }
}
