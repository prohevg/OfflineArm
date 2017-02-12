using System.Drawing;

namespace OfflineARM.Controller.Commands
{
    /// <summary>
	/// Метаданные команды
	/// </summary>
	public class CommandMetadata : ICommandMetadata
    {
        #region Поля

        /// <summary>
        /// Картинка команды
        /// </summary>
        private readonly Image _glyph;

        /// <summary>
        /// Заголовок команды
        /// </summary>
        private readonly string _caption;

        /// <summary>
        /// Тултип команды
        /// </summary>
        private readonly string _hint;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="caption">Заголовок команды</param>
        /// <param name="hint">Тултип команды</param>
        /// <param name="glyph">Картинка команды</param>
        public CommandMetadata(string caption, string hint, Image glyph)
        {
            this._caption = caption;
            this._hint = hint;
            this._glyph = glyph;
        }

        #endregion

        #region ICommandMetadata Members

        /// <summary>
        /// Возвращает картинку команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Картинка команды</returns>
        public Image GetGlyph(CommandState state)
        {
            return this._glyph;
        }

        /// <summary>
        /// Возвращает название команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Название команды</returns>
        public string GetCaption(CommandState state)
        {
            return this._caption;
        }

        /// <summary>
        /// Возвращает тултип команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Тултип команды</returns>
        public string GetHint(CommandState state)
        {
            return this._hint;
        }

        #endregion

        #region ICommandMetadataBase Members

        /// <summary>
        /// Заголовок команды
        /// </summary>
        string ICommandMetadataBase.Caption
        {
            get
            {
                return this._caption;
            }
        }

        /// <summary>
        /// Тултип команды
        /// </summary>
        string ICommandMetadataBase.Hint
        {
            get
            {
                return this._hint;
            }
        }

        #endregion
    }
}
