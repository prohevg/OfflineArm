using System;

namespace OfflineARM.Controller.ParsingCodes
{
    /// <summary>
    /// Парсинг дополнительной информации
    /// </summary>
    public class AdditionalInfoParseResult : ParseResult
    {
        /// <summary>
        /// Сумма кредита по БС
        /// </summary>
        public decimal CreditAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма ПВ по БС
        /// </summary>
        public decimal InitialFee
        {
            get;
            set;
        }

        /// <summary>
        /// Дата заключения договора
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }
    }
}