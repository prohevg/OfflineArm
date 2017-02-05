using OfflineARM.Repositories.Repositories.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Список справочников
    /// </summary>
    public interface IDictionaryRepositories
    {
        /// <summary>  
        /// Репозиторий Города  
        /// </summary>  
        ICityRepository CityRepository { get; }

        /// <summary>  
        /// Репозиторий Местонахождениe  
        /// </summary>  
        ILocationRepository LocationRepository { get; }

        /// <summary>  
        /// Репозиторий Действующего на основании  
        /// </summary>  
        IBasisActionRepository BasisActionRepository { get; }

        /// <summary>  
        /// Репозиторий Требование клиента
        /// </summary>  
        ICustomerRequirementRepository CustomerRequirementRepository { get; }

        /// <summary>  
        /// Репозиторий Номенклатура
        /// </summary>  
        INomenclatureRepository NomenclatureRepository { get; }

        /// <summary>  
        /// Репозиторий Характеристика номенклатуры
        /// </summary>  
        IFeatureRepository FeatureRepository { get; }

        /// <summary>  
        /// Репозиторий Банк
        /// </summary>  
        IBankRepository BankRepository { get; }

        /// <summary>  
        /// Банковский продукт
        /// </summary>  
        IBankProductRepository BankProductRepository { get; }

        /// <summary>  
        /// Группа номенклатур
        /// </summary>  
        INomenclatureGroupRepository NomenclatureGroupRepository { get; }

        /// <summary>  
        /// Пользователь
        /// </summary>  
        IUserRepository UserRepository { get; }

        /// <summary>
        /// Статус заказа
        /// </summary>
        IOrderStatusRepository OrderStatusRepository { get; }
    }
}
