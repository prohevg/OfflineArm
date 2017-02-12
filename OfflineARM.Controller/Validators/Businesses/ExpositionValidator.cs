using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Validators.Businesses
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
        public ValidationResult Validate(Exposition element)
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
