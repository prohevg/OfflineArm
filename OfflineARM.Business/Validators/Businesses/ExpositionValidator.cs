using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;

namespace OfflineARM.Business.Validators.Dictionaries
{
    /// <summary>
    /// Валидатор Экспозиция
    /// </summary>
    public class ExpositionValidator : IExpositionValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(IExpositionModel element)
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
