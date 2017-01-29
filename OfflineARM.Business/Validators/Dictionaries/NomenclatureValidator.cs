using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;

namespace OfflineARM.Business.Validators.Dictionaries
{
    /// <summary>
    /// Валидатор Номенклатуры
    /// </summary>
    public class NomenclatureValidator : INomenclatureValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(INomenclatureModel element)
        {
            if (string.IsNullOrEmpty(element.Name))
            {
                return new ValidationResult(ValidatorResources.NomenclatureValidator_NameIsNull);
            }

            return new ValidationResult();
        }

        #endregion
    }
}
