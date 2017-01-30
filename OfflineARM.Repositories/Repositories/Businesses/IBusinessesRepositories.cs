using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
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
    }
}
