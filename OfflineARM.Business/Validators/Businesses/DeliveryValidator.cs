using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;

namespace OfflineARM.Business.Validators.Businesses
{
    /// <summary>
    /// Валидатор Адрес доставки в заказе
    /// </summary>
    public class DeliveryValidator : IDeliveryValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(IDeliveryModel element)
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
