using System;
using OfflineARM.Controller.Commands;

namespace OfflineARM.Controller.Holders
{
    /// <summary>
    /// Базовая версия хранилища метаданных команд
    /// </summary>
    public abstract class CommandMetadataHolderBase : GenericSimpleHolder<Guid, ICommandMetadataBase>
    {
        /// <summary>
        /// Экземпляр
        /// </summary>
        private static CommandMetadataHolderBase _instance;

        /// <summary>
        /// Экземпляр
        /// </summary>
        public static CommandMetadataHolderBase Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        protected CommandMetadataHolderBase()
        {
            CommandMetadataHolderBase._instance = this;
        }

        /// <summary>
        /// Возвращает метаданные для команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <returns>Метаданные</returns>
        public ICommandMetadataBase GetMetadata(Guid commandId)
        {
            return this.GetValue(commandId);
        }
    }
}
