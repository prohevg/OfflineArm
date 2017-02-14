using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.Models.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Оплаты
    /// </summary>
    public interface IOrderPartPayView : IBaseView<IOrderPartPayController>
    {
        /// <summary>
        /// Сумма наличными
        /// </summary>
        decimal CashAmount { get; set; }

        /// <summary>
        /// Номер чека
        /// </summary>
        string CashFiscalReceipt { get; set; }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        bool CashInputManual { get; set; }

        /// <summary>
        /// Сумма картой
        /// </summary>
        decimal CardAmount { get; set; }

        /// <summary>
        /// Номер карты
        /// </summary>
        string CardNumber { get; set; }

        /// <summary>
        /// Оплата в ручную
        /// </summary>
        bool CardInputManual { get; set; }

        /// <summary>
        /// Путь к файлу для скана документа картой
        /// </summary>
        string CardPathToFile { get; set; }

        /// <summary>
        /// Поток файла
        /// </summary>
        byte[] CardFileStream { get; }

        /// <summary>
        /// Банк
        /// </summary>
        string CreditBank { get; set; }

        /// <summary>
        /// Банковский продукт
        /// </summary>
        string CreditBankProduct { get; set; }

        /// <summary>
        /// № договора
        /// </summary>
        string CreditBankOrderNumber { get; set; }

        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        decimal CreditAmount { get; set; }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        decimal CreditInitialFee { get; set; }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        string CreditNameInOrder { get; set; }

        /// <summary>
        /// Штрих код кредита
        /// </summary>
        string CreditScannerCode { get; set; }

        /// <summary>
        /// Добавить в таблицу оплат
        /// </summary>
        /// <param name="paymentRow">Оплата</param>
        void AddPaymentToGrid(PaymentRow paymentRow);

        /// <summary>
        /// Удалить из таблицы оплат
        /// </summary>
        /// <param name="paymentRow">Оплата</param>
        void RemovePaymentFromGrid(PaymentRow paymentRow);
    }
}
