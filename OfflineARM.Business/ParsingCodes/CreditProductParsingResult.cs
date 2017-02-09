using System;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Парсинг кредитного продукта
    /// </summary>
    public class CreditProductParsingParseResult : ParseResult
    {
        /// <summary>
        /// Признак наличия страховки
        /// $MS – продукт со страховкой 
        /// $MT – продукт без страховки
        /// </summary>
        public bool IsInsurance
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор банка
        /// </summary>
        public string BankId
        {
            get;
            set;
        }

        /// <summary>
        /// Кредитный продукт
        /// </summary>
        public string BankProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Срок кредита
        /// </summary>
        public int CreditTerm
        {
            get;
            set;
        }
    }
}