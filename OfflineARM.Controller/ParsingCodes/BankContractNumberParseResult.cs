using System;

namespace OfflineARM.Controller.ParsingCodes
{
    /// <summary>
    /// Парсинг номера кредитного договора
    /// </summary>
    public class BankContractNumberParseResult : ParseResult
    {
        /// <summary>
        /// Номер
        /// </summary>
        public string Number
        {
            get;
            set;
        }
    }
}