using System;

namespace OfflineARM.Controller.ParsingCodes
{
    /// <summary>
    /// Парсинг номера кредитного договора
    /// </summary>
    public class BankContractNumberParsing : ICodeParsing<BankContractNumberParseResult>
    {
        #region поля и свойства

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
        public BankContractNumberParsing(string code)
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
            return _code.Length <= 21;
        }

        /// <summary>
        /// Распарсить строку
        /// </summary>
        /// <returns></returns>
        public BankContractNumberParseResult Parse()
        {
            var result = new BankContractNumberParseResult
            {
                Number = _code
            };

            return result;
        }

        #endregion
    }
}
