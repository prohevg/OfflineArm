using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
