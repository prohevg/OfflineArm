using System;
using OfflineARM.Controller.Commands;
using OfflineARM.Controller.Helpers;

namespace OfflineARM.Controller.Holders
{
    /// <summary>
	/// Хранилище обработчиков диспетчеризуемых команд
	/// </summary>
	public class DispatchedCommandHolder : GenericSimpleHolder<Guid, Type>
    {
        /// <summary>
        /// Экземпляр
        /// </summary>
        public static readonly DispatchedCommandHolder Instance = new DispatchedCommandHolder();

        /// <summary>
        /// Закрытый конструктор
        /// </summary>
        private DispatchedCommandHolder()
        {
        }

        /// <summary>
        /// Задаёт тип обработчика команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <param name="handlerType">Тип обработчика</param>
        public void SetType(Guid commandId, Type handlerType)
        {
            if (commandId == Guid.Empty || handlerType == null ||
                !handlerType.IsDerivedFromGenericType(typeof(DispatchedCommandHandler<>)))
            {
                throw new InvalidOperationException(string.Format(ControllerResources.HolderCannotReplaceValueFormat, commandId, this.GetType()));
            }

            this.SetValue(commandId, handlerType);
        }

        /// <summary>
        /// Возвращает тип обработчика команды
        /// </summary>
        /// <param name="commandId">Идентификатор команды</param>
        /// <returns>Тип обработчика</returns>
        public Type GetType(Guid commandId)
        {
            return this.GetValue(commandId);
        }
    }
}
