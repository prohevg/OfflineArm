using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;

namespace OfflineARM.Business.Validators.Dictionaries
{
    /// <summary>
    /// Валидатор Статус заказа
    /// </summary>
    public class OrderStatusValidator : IOrderStatusValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(IOrderStatusModel element)
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
