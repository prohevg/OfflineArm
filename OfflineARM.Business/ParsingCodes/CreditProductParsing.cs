using System;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Парсинг кредитного продукта
    /// </summary>
    public class CreditProductParsing : ICodeParsing<CreditProductParsingParseResult>
    {
        #region поля и свойства

        /// <summary>
        /// Спец символы с которых начинается строка
        /// </summary>
        private const string BegginerPattern1 = "$MS";

        /// <summary>
        /// Спец символы с которых начинается строка
        /// </summary>
        private const string BegginerPattern2 = "$MT";

        /// <summary>
        /// Код
        /// </summary>
        private readonly string _code;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="code">Код</param>
        public CreditProductParsing(string code)
        {
            _code = code.ToUpper();
        }

        #endregion

        #region ICodeParsing

        /// <summary>
        /// Возможен парсинг строки штрихкода (соответствует маске)
        /// </summary>
        public bool CanParse()
        {
            return (_code.StartsWith(BegginerPattern1) || _code.StartsWith(BegginerPattern2)) && _code.Length == 21;
        }

        /// <summary>
        /// Распарсить строку
        /// </summary>
        /// <returns></returns>
        public CreditProductParsingParseResult Parse()
        {
            var result = new CreditProductParsingParseResult
            {
                IsInsurance = _code.StartsWith(BegginerPattern1),
                BankId = _code.Substring(4, 3),
                BankProductId = _code.Substring(8, 8),
                CreditTerm = Int32.Parse(_code.Substring(17, 3))
            };

            return result;
        }

        #endregion
    }
}
