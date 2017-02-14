using System.Collections.Generic;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.Controllers.Orders;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.ControllerInterfaces.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public interface IOrderPartPayController : IBaseController
    {
        /// <summary>
        /// Сумма заказа
        /// </summary>
        decimal OrderAmount { get; set; }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        List<CashPayment> CashPayments { get; set; }

        /// <summary>
        /// Оплата картой
        /// </summary>
        List<CardPayment> CardPayments { get; set; }

        /// <summary>
        /// Оплата кредитом
        /// </summary>
        List<CreditPayment> CreditPayments { get; set; }

        /// <summary>
        /// Контроллер главной формы
        /// </summary>
        OrderEditController MainController { get; set; }

        /// <summary>
        /// Список документов на оплату
        /// </summary>
        IReadOnlyList<OrderDocument> OrderDocuments { get; }

        /// <summary>
        /// Добавить оплату наличными
        /// </summary>
        void AddNewCashPayment();

        /// <summary>
        /// Добавить оплату картой
        /// </summary>
        void AddNewCardPayment();

        /// <summary>
        /// Добавить оплату кредитом
        /// </summary>
        void AddNewCreditPayment();

        /// <summary>
        /// Распарсить штрихкод
        /// </summary>
        void ParseCode();

        /// <summary>
        /// Удалить из оплат
        /// </summary>
        /// <param name="paymentRow"></param>
        void RemoveFromPayment(PaymentRow paymentRow);
    }
}
