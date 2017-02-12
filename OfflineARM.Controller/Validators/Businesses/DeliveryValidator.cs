using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Validators.Businesses
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
        public ValidationResult Validate(Delivery element)
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
