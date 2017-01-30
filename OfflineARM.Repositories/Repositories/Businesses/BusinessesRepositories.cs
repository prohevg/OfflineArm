using OfflineARM.DAO;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Репозитарии бизнеса
    /// </summary>
    public class BusinessesRepositories : IBusinessesRepositories
    {
        #region поля и свойства

        /// <summary>
        /// Контекст выполнения БД
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Репозиторий Экспозиция
        /// </summary>
        private IExpositionRepository _expositionRepository;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BusinessesRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion

        #region свойства репозиториев

        /// <summary>  
        /// Репозиторий Экспозиция  
        /// </summary>  
        public IExpositionRepository ExpositionRepository
        {
            get
            {
                if (this._expositionRepository == null)
                {
                    this._expositionRepository = new ExpositionRepository(_context);
                }
                return _expositionRepository;
            }
        }       

        #endregion
    }
}
