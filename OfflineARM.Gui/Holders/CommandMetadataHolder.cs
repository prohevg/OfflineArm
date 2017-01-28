using System;
using System.Drawing;
using OfflineARM.Gui.Commands;

namespace OfflineARM.Gui.Holders
{
    /// <summary>
	/// Хранилище метаданных команд
	/// </summary>
	public class CommandMetadataHolder : CommandMetadataHolderBase
    {
        /// <summary>
        /// Экземпляр
        /// </summary>
        public static readonly CommandMetadataHolder Instance = new CommandMetadataHolder();

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        private CommandMetadataHolder()
        {
        }

        /// <summary>
        /// Задаёт метаданные для команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <param name="metadata">Метаданные</param>
        public void SetMetadata(Guid commandId, ICommandMetadata metadata)
        {
            if (commandId == Guid.Empty || metadata == null)
            {
                throw new InvalidOperationException(string.Format(GuiResource.HolderCannotReplaceValueFormat, commandId, this.GetType()));
            }
            this.SetValue(commandId, metadata);
        }

        /// <summary>
        /// Задаёт метаданные для команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <param name="glyph">Картинка</param>
        /// <param name="caption">Наименование команды</param>
        /// <param name="hint">Тултип команды</param>
        public void SetMetadata(Guid commandId, Image glyph, string caption, string hint)
        {
            if (commandId == Guid.Empty)
            {
                throw new InvalidOperationException(string.Format(GuiResource.HolderCannotReplaceValueFormat, commandId, this.GetType()));
            }
            this.SetValue(commandId, new CommandMetadata(caption, hint, glyph));
        }

        /// <summary>
        /// Возвращает метаданные для команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <returns>Метаданные</returns>
        public new ICommandMetadata GetMetadata(Guid commandId)
        {
            return (ICommandMetadata)this.GetValue(commandId);
        }
    }
}
