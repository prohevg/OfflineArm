using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Validators.Businesses
{
    /// <summary>
    /// Валидатор Пользователи
    /// </summary>
    public class UserValidator : IUserValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(User element)
        {
            //if (string.IsNullOrEmpty(element.Name))
            //{
            //    return new ValidationResult(ValidatorResources.ExpositionValidator_NameIsNull);
            //}

            return new ValidationResult();
        }

        #endregion
    }
}
