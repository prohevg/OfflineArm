using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;

namespace OfflineARM.Business.Validators.Dictionaries
{
    /// <summary>
    /// Валидатор Характеристика номенклатуры
    /// </summary>
    public class BasisActionValidator : IBasisActionValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(IBasisActionModel element)
        {
            //if (string.IsNullOrEmpty(elementю))
            //{
            //    return new ValidationResult(ValidatorResources.CharacteristicValidator_NameIsNull);
            //}

            return new ValidationResult();
        }

        #endregion
    }
}
