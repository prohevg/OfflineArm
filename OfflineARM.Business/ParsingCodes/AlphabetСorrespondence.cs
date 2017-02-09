using System.Collections.Generic;

namespace OfflineARM.Business.ParsingCodes
{
    /// <summary>
    /// Соответствие латиницы и кириллицы
    /// </summary>
    public class AlphabetСorrespondence
    {
        #region поля и свойства

        /// <summary>
        /// Соответствие латиницы и кириллицы
        /// </summary>
        public static readonly AlphabetСorrespondence Instance = new AlphabetСorrespondence();

        /// <summary>
        /// Соответствие латиницы и кириллицы
        /// </summary>
        private readonly Dictionary<char, char> _chars = new Dictionary<char, char>();

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        private AlphabetСorrespondence()
        {
            _chars.Add('A', 'А');
            _chars.Add('B', 'Б');
            _chars.Add('V', 'В');
            _chars.Add('G', 'Г');
            _chars.Add('D', 'Д');
            _chars.Add('E', 'Е');
            _chars.Add('1', 'Ё');
            _chars.Add('Q', 'Ж');
            _chars.Add('Z', 'З');
            _chars.Add('I', 'И');
            _chars.Add('J', 'Й');
            _chars.Add('K', 'К');
            _chars.Add('L', 'Л');
            _chars.Add('M', 'М');
            _chars.Add('N', 'Н');
            _chars.Add('O', 'О');
            _chars.Add('P', 'П');
            _chars.Add('R', 'Р');
            _chars.Add('S', 'С');
            _chars.Add('T', 'Т');
            _chars.Add('U', 'У');
            _chars.Add('F', 'Ф');
            _chars.Add('H', 'Х');
            _chars.Add('C', 'Ц');
            _chars.Add('4', 'Ч');
            _chars.Add('W', 'Ш');
            _chars.Add('3', 'Щ');
            _chars.Add('9', 'Ъ');
            _chars.Add('5', 'Ы');
            _chars.Add('6', 'Ь');
            _chars.Add('7', 'Э');
            _chars.Add('8', 'Ю');
            _chars.Add('Y', 'Я');
        }

        #endregion

        #region методы

        /// <summary>
        /// Кириллица
        /// </summary>
        /// <param name="key">латиница</param>
        /// <returns></returns>
        public char GetCyrillic(char key)
        {
            return _chars[key];
        }

        #endregion
    }
}