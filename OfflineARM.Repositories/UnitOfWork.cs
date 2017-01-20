using System;
using System.Data.Entity.Validation;
using OfflineARM.DAO;
using OfflineARM.Repositories.Repositories;
using OfflineARM.Repositories.Repositories.Interfaces;

namespace OfflineARM.Repositories
{
    /// <summary>  
    /// Unit of Work
    /// </summary>  
    public class UnitOfWork : IDisposable
    {
        #region поля и свойства

        /// <summary>
        /// true - если был вызван Dispose
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// Контекст выполнения БД
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Репозиторий Города
        /// </summary>
        private ICityRepository _cityRepository;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }

        #endregion

        #region свойства репозиториев

        /// <summary>  
        /// Репозиторий Города  
        /// </summary>  
        public ICityRepository CityRepository
        {
            get
            {
                if (this._cityRepository == null)
                {
                    this._cityRepository = new CityRepository(_context);
                }
                return _cityRepository;
            }
        }

        #endregion

        #region методы

        /// <summary>  
        /// Сохранить контекст  
        /// </summary>  
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                //var outputLines = new List<string>();
                //foreach (var eve in e.EntityValidationErrors)
                //{
                //    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                //    foreach (var ve in eve.ValidationErrors)
                //    {
                //        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                //    }
                //}

                throw e;
            }
        }

        #endregion

        #region IDisposable

        /// <summary>  
        /// IDisposable
        /// </summary>  
        /// <param name="disposing"></param>  
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed && disposing)
            {
                _context.Dispose();
            }
            this._disposed = true;
        }

        /// <summary>  
        /// Dispose  
        /// </summary>  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
