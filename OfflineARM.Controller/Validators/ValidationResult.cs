using System;
using System.Collections.Generic;
using System.Linq;

namespace OfflineARM.Controller.Validators
{
    /// <summary>
    /// Результат валидации
    /// </summary>
    public class ValidationResult
    {
        #region поля и свойства

        /// <summary>
        /// Валидация успешно пройдена
        /// </summary>
        public bool IsSucceeded
        {
            get;
            set;
        }

        /// <summary>
        /// Ошибки валидации
        /// </summary>
        public IEnumerable<ErrorData> Errors
        {
            get;
            private set;
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Ошибкf</param>
        public ValidationResult(string message)
        {
            Errors = new List<ErrorData>()
            {
                new ErrorData(message)
            };
            IsSucceeded = false;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="errors">Ошибки</param>
        public ValidationResult(IEnumerable<ErrorData> errors = null)
        {
            Errors = errors ?? new List<ErrorData>();
            IsSucceeded = (errors == null || !errors.Any());
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Расшифровка ошибки</param>
        /// <param name="parameters">Параметры сообщения</param>
        public ValidationResult(string message, object[] parameters = null)
        {
            var result = new List<ErrorData>()
            {
                new ErrorData(message, parameters)
            };
            Errors = result;
            IsSucceeded = !result.Any();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parameters">Параметры сообщения</param>
        public ValidationResult(int parameters)
        {
            var result = new List<ErrorData>()
            {
                new ErrorData(string.Empty, new object[] { parameters })
            };
            Errors = result;
            IsSucceeded = !result.Any();
        }

        #endregion
    }
}
