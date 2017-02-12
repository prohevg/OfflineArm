using OfflineARM.Controller.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Validators.Dictionaries
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
        public ValidationResult Validate(BasisAction element)
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
