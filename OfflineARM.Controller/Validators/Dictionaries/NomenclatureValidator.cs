using OfflineARM.Controller.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Validators.Dictionaries
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
        public ValidationResult Validate(Nomenclature element)
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
