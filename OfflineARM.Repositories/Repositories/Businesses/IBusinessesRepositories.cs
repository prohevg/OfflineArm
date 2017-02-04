using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Репозитарии бизнеса
    /// </summary>
    public interface IBusinessesRepositories
    {
        /// <summary>  
        /// Репозиторий Экспозиция  
        /// </summary>  
        IExpositionRepository ExpositionRepository { get; }

        /// <summary>
        /// Заказ
        /// </summary>
        IOrderRepository OrderRepository { get; }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        IOrderSpecificationItemRepository OrderSpecificationRepository { get; }

        /// <summary>
        /// Оплата картой
        /// </summary>
        ICardPaymentRepository CardPaymentRepository { get; }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        ICashPaymentRepository CashPaymentRepository { get; }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        ICreditPaymentRepository CreditPaymentRepository { get; }

        /// <summary>
        ///  Клиент юр лицо
        /// </summary>
        ICustomerLegalRepository CustomerLegalRepository { get; }

        /// <summary>
        ///  Клиент физ лицо
        /// </summary>
        ICustomerPrivateRepository CustomerPrivateRepository { get; }
    }
}
