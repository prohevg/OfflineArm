using System;
using System.Globalization;

namespace OfflineARM.Controller.ParsingCodes
{
    /// <summary>
    /// Парсинг дополнительной информации
    /// </summary>
    public class AdditionalInfoParsing : ICodeParsing<AdditionalInfoParseResult>
    {
        #region поля и свойства

        /// <summary>
        /// Спец символы с которых начинается строка
        /// </summary>
        private const string BegginerPattern = "E%";

        /// <summary>
        /// Код
        /// </summary>
        private readonly string _code;

        /// <summary>
        /// Код
        /// </summary>
        private readonly string _prepareCode;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="code">Код</param>
        public AdditionalInfoParsing(string code)
        {
            _code = code.Replace(" ", "").
                ToUpper();

            _prepareCode = code.Replace(BegginerPattern, "")
                .Replace(" ", "")
                .ToUpper();
        }

        #endregion

        #region ICodeParsing

        /// <summary>
        /// Возможен парсинг строки штрихкода (соответствует маске)
        /// </summary>
        public bool CanParse()
        {
            return _code.StartsWith(BegginerPattern) && _code.Length == 24;
        }

        /// <summary>
        /// Распарсить строку
        /// </summary>
        /// <returns></returns>
        public AdditionalInfoParseResult Parse()
        {
            var result = new AdditionalInfoParseResult();

            var amountCreditRuble = _prepareCode.Substring(0, 6);
            var amountCreditKopeck = _prepareCode.Substring(6, 2);

            var amountInitialFeeRuble = _prepareCode.Substring(8, 6);
            var amountInitialFeeKopeck = _prepareCode.Substring(14, 2);

            var dateDogovor =  _prepareCode.Substring(16, 6);

            result.CreditAmount = decimal.Parse(amountCreditRuble + "," + amountCreditKopeck);
            result.InitialFee = decimal.Parse(amountInitialFeeRuble + "," + amountInitialFeeKopeck);
            result.Date = DateTime.ParseExact(dateDogovor, "ddMMyy", new CultureInfo("ru-RU"));

            return result;
        }

        #endregion
    }
}
