using System.Text;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Парсинг ФИО клиента
    /// </summary>
    public class ClientNameParsing : ICodeParsing<ClientNameParseResult>
    {
        #region поля и свойства

        /// <summary>
        /// Спец символы с которых начинается строка
        /// </summary>
        private const string BegginerPattern = "N%";

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
        public ClientNameParsing(string code)
        {
            _code = code.Replace(" ", "").
                ToUpper();

            _prepareCode = code.Replace(BegginerPattern, "")
                .Replace("%", " ")
                .ToUpper();
        }

        #endregion

        #region ICodeParsing

        /// <summary>
        /// Возможен парсинг строки штрихкода (соответствует маске)
        /// </summary>
        public bool CanParse()
        {
            return _code.StartsWith(BegginerPattern) && _code.Length <= 40;
        }

        /// <summary>
        /// Распарсить строку
        /// </summary>
        /// <returns></returns>
        public ClientNameParseResult Parse()
        {
            var result = new ClientNameParseResult();

            var sb = new StringBuilder();
            foreach (var letter in _prepareCode)
            {
                if (char.IsSeparator(letter))
                {
                    sb.Append(letter);
                    continue;
                }

                var cyrilicChar = AlphabetСorrespondence.Instance.GetCyrillic(letter);
                sb.Append(cyrilicChar);
            }

            result.Fio = sb.ToString();

            return result;
        }

        #endregion
    }
}
