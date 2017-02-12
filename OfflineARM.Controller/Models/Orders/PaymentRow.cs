using System;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Models.Orders
{
    /// <summary>
    /// Строка оплата в таблице оплат заказа
    /// </summary>
    public class PaymentRow
    {
        /// <summary>
        /// Guid
        /// </summary>
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime PaymentDate
        {
            get;
            set;
        }

        /// <summary>
        /// Тип оплаты
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        public bool IsManual
        {
            get;
            set;
        }
    
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="cashPayment">Оплата</param>
        public PaymentRow(CashPayment cashPayment)
        {
            this.Guid = cashPayment.Guid;
            this.PaymentDate = cashPayment.PaymentDate;
            this.Type = ControllerResources.OrderPayControl_CashPaymentType;
            this.Amount = cashPayment.Amount;
            this.IsManual = cashPayment.Manual;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="cardPayment">Оплата</param>
        public PaymentRow(CardPayment cardPayment)
        {
            this.Guid = cardPayment.Guid;
            this.PaymentDate = cardPayment.PaymentDate;
            this.Type = ControllerResources.OrderPayControl_CardPaymentType;
            this.Amount = cardPayment.Amount;
            this.IsManual = cardPayment.Manual;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="creditPayment">Оплата</param>
        public PaymentRow(CreditPayment creditPayment)
        {
            this.Guid = creditPayment.Guid;
            this.PaymentDate = creditPayment.PaymentDate;
            this.Type = ControllerResources.OrderPayControl_CreditPaymentType;
            this.Amount = creditPayment.Amount;
        }
    }
}
