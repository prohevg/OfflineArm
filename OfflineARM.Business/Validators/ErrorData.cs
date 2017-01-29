using System;

namespace OfflineARM.Business.Validators
{
    /// <summary>
    /// Ошибка с описанием
    /// </summary>
    public class ErrorData
    {
        #region поля и свойства

        /// <summary>
        /// Расшифровка ошибки
        /// </summary>
        public string Message
        {
            get;
            private set;
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Расшифровка ошибки</param>
        /// <param name="parameters">Параметры сообщения</param>
        public ErrorData(string message, object[] parameters = null)
        {
            Message = parameters != null ? string.Format(message, parameters) : message;
        }

        #endregion
    }
}
