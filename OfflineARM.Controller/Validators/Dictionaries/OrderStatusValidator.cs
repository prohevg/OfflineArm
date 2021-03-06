﻿using OfflineARM.Controller.Validators.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.Validators.Dictionaries
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
        public ValidationResult Validate(OrderStatus element)
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
