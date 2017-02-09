using System;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Парсинг в зависимости от строки
    /// </summary>
    public class ParseContext
    {
        /// <summary>
        /// Выполнить парсинг строки
        /// </summary>
        /// <param name="code">Штрихкод</param>
        public static ParseResult Execute(string code)
        {
            code = code.ToUpper();

            var additionalInfoParsing = new AdditionalInfoParsing(code);
            if (additionalInfoParsing.CanParse())
            {
                return additionalInfoParsing.Parse();
            }

            var creditProductParsing = new CreditProductParsing(code);
            if (creditProductParsing.CanParse())
            {
                return creditProductParsing.Parse();
            }


            var clientNameParsing = new ClientNameParsing(code);
            if (clientNameParsing.CanParse())
            {
                return clientNameParsing.Parse();
            }

            var bankContractNumberParsing = new BankContractNumberParsing(code);
            if (bankContractNumberParsing.CanParse())
            {
                return bankContractNumberParsing.Parse();
            }

            throw new NotImplementedException("parsing NotImplementedException");
        }
    }
}
