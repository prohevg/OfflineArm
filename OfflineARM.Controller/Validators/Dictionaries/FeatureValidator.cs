using OfflineARM.Controller.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Validators.Dictionaries
{
    /// <summary>
    /// Валидатор Характеристика номенклатуры
    /// </summary>
    public class FeatureValidator : IFeatureValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(Feature element)
        {
            if (string.IsNullOrEmpty(element.Name))
            {
                return new ValidationResult(ValidatorResources.CharacteristicValidator_NameIsNull);
            }

            return new ValidationResult();
        }

        #endregion
    }
}
