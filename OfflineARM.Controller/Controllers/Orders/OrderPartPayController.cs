using System;
using System.Collections.Generic;
using System.Linq;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.Controller.ParsingCodes;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Controllers.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public class OrderPartPayController : BaseController, IOrderPartPayController
    {
        #region поля и свойства

        /// <summary>
        /// View оплата заказа
        /// </summary>
        private IOrderPartPayView _orderPayView;

        /// <summary>
        /// Оплаты наличными
        /// </summary>
        private List<CashPayment> _cashPayments = new List<CashPayment>();

        /// <summary>
        /// Оплаты картой
        /// </summary>
        private List<CardPayment> _cardPayments = new List<CardPayment>();

        /// <summary>
        /// Оплаты кредитом
        /// </summary>
        private List<CreditPayment> _creditPayments = new List<CreditPayment>();

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _orderPayView = (IOrderPartPayView)view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {
            
        }

        #endregion

        #region IOrderPartPayController

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal OrderAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        public List<CashPayment> CashPayments
        {
            get
            {
                return _cashPayments;
            }
            set
            {
                _cashPayments = value;
            }
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        public List<CardPayment> CardPayments
        {
            get
            {
                return _cardPayments;
            }
            set
            {
                _cardPayments = value;
            }
        }

        /// <summary>
        /// Оплата кредитом
        /// </summary>
        public List<CreditPayment> CreditPayments
        {
            get
            {
                return _creditPayments;
            }
            set
            {
                _creditPayments = value;
            }
        }

        /// <summary>
        /// Контроллер главной формы
        /// </summary>
        public OrderEditController MainController
        {
            get;
            set;
        }

        /// <summary>
        /// Добавить оплату наличными
        /// </summary>
        public void AddNewCashPayment()
        {
            var cashPayment = new CashPayment()
            {
                Guid = Guid.NewGuid(),
                PaymentDate = DateTime.Now,
                Amount = _orderPayView.CashAmount,
                Manual = _orderPayView.CashInputManual,
                FiscalReceipt = _orderPayView.CashFiscalReceipt,
                DocumentName = _orderPayView.CashPathToFile
            };

            _cashPayments.Add(cashPayment);

            var paymentRow = new PaymentRow(cashPayment);

            _orderPayView.AddPaymentToGrid(paymentRow);

            MainController.RecalculatePayment();
        }

        /// <summary>
        /// Добавить оплату картой
        /// </summary>
        public void AddNewCardPayment()
        {
            var cardPayment = new CardPayment()
            {
                Guid = Guid.NewGuid(),
                PaymentDate = DateTime.Now,
                Amount = _orderPayView.CardAmount,
                CardNumber = _orderPayView.CardNumber,
                Manual = _orderPayView.CardInputManual,
                RNN = _orderPayView.CardNumber,
                DocumentName = _orderPayView.CardPathToFile
            };

            _cardPayments.Add(cardPayment);

            var paymentRow = new PaymentRow(cardPayment);

            _orderPayView.AddPaymentToGrid(paymentRow);

            MainController.RecalculatePayment();
        }

        /// <summary>
        /// Добавить оплату кредитом
        /// </summary>
        public void AddNewCreditPayment()
        {
            var creditPayment = new CreditPayment()
            {
                Guid = Guid.NewGuid(),
                PaymentDate = DateTime.Now,
                Amount = _orderPayView.CreditAmount,
                Bank = new Bank() { Id = 1 },
                BankProduct = new BankProduct() { Id = 1 },
                BankOrderNumber = _orderPayView.CreditBankOrderNumber,
                CreditAmount = _orderPayView.CreditAmount,
                InitialFee = _orderPayView.CreditInitialFee,
                NameInOrder = _orderPayView.CreditNameInOrder
            };

            _creditPayments.Add(creditPayment);

            var paymentRow = new PaymentRow(creditPayment);

            _orderPayView.AddPaymentToGrid(paymentRow);

            MainController.RecalculatePayment();
        }

        /// <summary>
        /// Распарсить штрихкод
        /// </summary>
        public void ParseCode()
        {
            var result = ParseContext.Execute(_orderPayView.CreditScannerCode);

            var bankContractNumberParseResult = result as BankContractNumberParseResult;
            if (bankContractNumberParseResult != null)
            {
                _orderPayView.CreditBankOrderNumber = bankContractNumberParseResult.Number;
            }

            var clientNameParseResult = result as ClientNameParseResult;
            if (clientNameParseResult != null)
            {
                _orderPayView.CreditNameInOrder = clientNameParseResult.Fio;
            }

            var creditProductParsingResult = result as CreditProductParseResult;
            if (creditProductParsingResult != null)
            {
                _orderPayView.CreditBank = creditProductParsingResult.BankId;
                _orderPayView.CreditBankProduct = creditProductParsingResult.BankProductId;
            }

            var additionalInfoParseResult = result as AdditionalInfoParseResult;
            if (additionalInfoParseResult != null)
            {
                _orderPayView.CreditAmount = additionalInfoParseResult.CreditAmount;
                _orderPayView.CreditInitialFee = additionalInfoParseResult.InitialFee;
            }
        }

        /// <summary>
        /// Удалить из оплат
        /// </summary>
        /// <param name="paymentRow"></param>
        public void RemoveFromPayment(PaymentRow paymentRow)
        {
            var cash = _cashPayments.FirstOrDefault(c => c.Guid == paymentRow.Guid);
            if (cash != null)
            {
                _cashPayments.Remove(cash);
            }

            var card = _cardPayments.FirstOrDefault(c => c.Guid == paymentRow.Guid);
            if (card != null)
            {
                _cardPayments.Remove(card);
            }

            var credit = _creditPayments.FirstOrDefault(c => c.Guid == paymentRow.Guid);
            if (credit != null)
            {
                _creditPayments.Remove(credit);
            }

            _orderPayView.RemovePaymentFromGrid(paymentRow);
        }

        #endregion
    }
}
