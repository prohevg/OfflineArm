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
        IOrderSpecificationRepository OrderSpecificationRepository { get; }
    }
}
