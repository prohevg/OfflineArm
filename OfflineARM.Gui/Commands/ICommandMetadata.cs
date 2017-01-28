using System.Drawing;

namespace OfflineARM.Gui.Commands
{
    /// <summary>
	/// Метаданные команды
	/// </summary>
	public interface ICommandMetadata : ICommandMetadataBase
    {
        /// <summary>
        /// Возвращает картинку команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Картинка команды</returns>
        Image GetGlyph(CommandState state);

        /// <summary>
        /// Возвращает название команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Название команды</returns>
        string GetCaption(CommandState state);

        /// <summary>
        /// Возвращает тултип команды
        /// </summary>
        /// <param name="state">Состояние команды</param>
        /// <returns>Тултип команды</returns>
        string GetHint(CommandState state);
    }
}
