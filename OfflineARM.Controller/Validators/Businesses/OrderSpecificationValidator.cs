using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Validators.Businesses
{
    /// <summary>
    /// Валидатор Спецификация заказа
    /// </summary>
    public class OrderSpecificationValidator : IOrderSpecificationValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(OrderSpecificationItem element)
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
