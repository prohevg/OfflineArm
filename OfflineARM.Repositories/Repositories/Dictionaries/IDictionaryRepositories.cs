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
    }
}
