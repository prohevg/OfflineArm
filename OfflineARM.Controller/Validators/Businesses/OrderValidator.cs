using System;
using System.Linq;
using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Controller.Validators.Businesses
{
    /// <summary>
    /// Валидатор Заказ
    /// </summary>
    public class OrderValidator : IOrderValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(Order element)
        {
            if (element.OrderSpecifications == null || element.OrderSpecifications.Count == 0)
            {
                return new ValidationResult(ValidatorResources.OrderValidator_OrderSpecificationsIsNull);
            }

            if ((element.CustomerPrivate == null && !element.CustomerPrivateId.HasValue)
                && (element.CustomerLegal == null && !element.CustomerLegalId.HasValue))
            {
                return new ValidationResult(ValidatorResources.OrderValidator_CustomerIsNull);
            }

            if (element.Delivery != null && string.IsNullOrWhiteSpace(element.Delivery.Address))
            {
                return new ValidationResult(ValidatorResources.OrderValidator_DeliveryIsNull);
            }

            if (element.Delivery != null && element.Delivery.DeliveryDate == DateTime.MinValue)
            {
                return new ValidationResult(ValidatorResources.OrderValidator_DeliveryDateIsNull);
            }

            if (element.CustomerPrivate != null || element.CustomerPrivateId.HasValue)
            {
                if (element.CashPayments == null && element.CardPayments == null && element.CreditPayments == null)
                {
                    return new ValidationResult(ValidatorResources.OrderValidator_PaymentLess30);
                }

                if (element.CashPayments != null && element.CashPayments.Count == 0 
                    && element.CardPayments != null && element.CardPayments.Count == 0
                    && element.CreditPayments != null && element.CreditPayments.Count == 0)
                {
                    return new ValidationResult(ValidatorResources.OrderValidator_PaymentLess30);
                }

                var cashAmount = element.CashPayments != null ? element.CashPayments.Sum(c => c.Amount) : 0;
                var cardAmount = element.CardPayments != null ? element.CardPayments.Sum(c => c.Amount) : 0;
                var creditAmount = element.CreditPayments != null ? element.CreditPayments.Sum(c => c.Amount) : 0;

                var totalPayment = cashAmount + cardAmount + creditAmount;

                var totalSpec = element.OrderSpecifications.Sum(s => s.PriceWithDiscount);

                if (100 / (totalSpec / totalPayment) < 30)
                {
                    return new ValidationResult(ValidatorResources.OrderValidator_PaymentLess30);
                }
            }

            return new ValidationResult();
        }

        #endregion
    }
}
