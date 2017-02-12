using System.Collections.Generic;
using System.Threading.Tasks;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities;

namespace OfflineARM.Repositories.Repositories
{
    /// <summary>  
    /// Базовый репозиторий
    /// </summary>  
    /// <typeparam name="TDaoEntity">Тип сущности Dao</typeparam> 
    public interface IBaseRepository<TDaoEntity> where TDaoEntity : IBaseDaoEntity
    {
        #region методы

        /// <summary>  
        /// Найти по Id 
        /// </summary>  
        /// <param name="id">Id</param>  
        /// <returns></returns>  
        TDaoEntity GetById(int id);

        /// <summary>  
        /// Добавить
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        void Insert(TDaoEntity entity);

        /// <summary>  
        /// Удалить по Id 
        /// </summary>  
        /// <param name="id">Id</param>  
        void Delete(int id);

        /// <summary>  
        /// Удалить
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        void Delete(TDaoEntity entity);

        /// <summary>  
        /// Обновить  
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        void Update(TDaoEntity entity);

        /// <summary>  
        /// Получить все записи
        /// </summary>  
        PagedResult<TDaoEntity> GetAll();

        /// <summary>  
        /// Получить все записи асинхронно
        /// </summary>  
        Task<PagedResult<TDaoEntity>> GetAllAsync();

        /// <summary>  
        /// Получить количество записей
        /// </summary>  
        /// <returns></returns>  
        int Count();

        #endregion
    }
}
