using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities;

namespace OfflineARM.Repositories.Repositories
{
    /// <summary>  
    /// Базовый репозиторий
    /// </summary>  
    /// <typeparam name="TDaoEntity">Тип сущности Dao</typeparam> 
    public abstract class BaseRepository<TDaoEntity> : IBaseRepository<TDaoEntity>
        where TDaoEntity : class, IBaseDaoEntity
    {
        #region поля и свойства

        /// <summary>
        /// Контекст выполнения БД
        /// </summary>
        protected ApplicationDbContext Context;

        /// <summary>
        /// Сущность БД
        /// </summary>
        protected DbSet<TDaoEntity> DbSet;

        #endregion

        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        protected BaseRepository(ApplicationDbContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<TDaoEntity>();
        }

        #endregion

        #region методы

        /// <summary>  
        /// Найти по Id 
        /// </summary>  
        /// <param name="id">Id</param>  
        /// <returns></returns>  
        public virtual TDaoEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        /// <summary>  
        /// Добавить
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        public virtual void Insert(TDaoEntity entity)
        {
            DbSet.Add(entity);
        }

        /// <summary>  
        /// Обновить  
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        public virtual void Update(TDaoEntity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>  
        /// Удалить по Id 
        /// </summary>  
        /// <param name="id">Id</param>  
        public virtual void Delete(int id)
        {
            TDaoEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>  
        /// Удалить
        /// </summary>  
        /// <param name="entity">Сущность DAO</param>  
        public virtual void Delete(TDaoEntity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }

        /// <summary>  
        /// Получить все записи
        /// </summary>  
        public virtual PagedResult<TDaoEntity> GetAll()
        {
            var list = DbSet;
            if (list == null)
            {
                return new PagedResult<TDaoEntity>(new List<TDaoEntity>(), 1, 1, 0);
            }

            var count = DbSet.Count();
            return new PagedResult<TDaoEntity>(list, 1, 1, count);
        }

        /// <summary>  
        /// Получить все записи
        /// </summary>  
        public virtual Task<PagedResult<TDaoEntity>> GetAllAsync()
        {
            return Task.Factory.StartNew(() => GetAll());
        }

        /// <summary>  
        /// Получить количество записей
        /// </summary>  
        /// <returns></returns>  
        public virtual int Count()
        {
            return DbSet.Count();
        }

        #endregion
    }
}
