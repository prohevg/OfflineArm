using System;
using System.Threading;

namespace OfflineARM.Controller.Holders
{
    /// <summary>
	/// Сервис для работы с ReaderWriterLockSlim без таймаутов ожидания
	/// </summary>
	public class ReaderWriterLockService : IDisposable
    {
        #region Перечисление типов запрашиваемой блокировки

        /// <summary>
        /// Тип блокировки
        /// </summary>
        public enum LockType
        {
            /// <summary>
            /// Блокировка чтения
            /// </summary>
            Reader,

            /// <summary>
            /// Блокировка записи
            /// </summary>
            Writer,

            /// <summary>
            /// Блокировка чтения с возможностью эскалации до блокировки записи
            /// </summary>
            UpgradeableReader
        }

        #endregion

        #region Поля

        /// <summary>
		/// Флаг запуска
		/// </summary>
		protected bool _isStarted;

        /// <summary>
        /// Флаг завершенности
        /// </summary>
        protected bool _isFinished;

        private readonly ReaderWriterLockSlim _lock;

        private readonly LockType _lockType;

        private readonly bool _checkHeldLock;

        private readonly bool _noEscalate;

        #endregion

        #region Свойства

        private bool HeldNoLock
        {
            get
            {
                return !this._lock.IsReadLockHeld && !this._lock.IsWriteLockHeld && !this._lock.IsUpgradeableReadLockHeld;
            }
        }

        private bool HeldNoLockExcept(LockType lockType)
        {
            switch (lockType)
            {
                case LockType.Reader:
                    return !this._lock.IsWriteLockHeld && !this._lock.IsUpgradeableReadLockHeld;
                case LockType.UpgradeableReader:
                    return !this._lock.IsReadLockHeld && !this._lock.IsWriteLockHeld;
                case LockType.Writer:
                    return !this._lock.IsReadLockHeld && !this._lock.IsUpgradeableReadLockHeld;
                default:
                    return false;
            }
        }

        private bool AllowsRecoursive
        {
            get
            {
                if (this._lock.RecursionPolicy == LockRecursionPolicy.NoRecursion)
                {
                    return false;
                }

                switch (this._lockType)
                {
                    case LockType.Reader:
                        return this._lock.IsReadLockHeld;
                    case LockType.UpgradeableReader:
                        return this._lock.IsUpgradeableReadLockHeld;
                    case LockType.Writer:
                        return this._lock.IsWriteLockHeld;
                    default:
                        return false;
                }
            }
        }

        #endregion

        #region Получение экземпляра без проверок на наличие установленных ранее блокировок

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой чтения
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetReader(ReaderWriterLockSlim rwlock)
        {
            return Get(rwlock, LockType.Reader, true);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой чтения
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetUpgradeableReader(ReaderWriterLockSlim rwlock)
        {
            return Get(rwlock, LockType.UpgradeableReader, true);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой записи.
        /// Возможна эскалация блокировки, что при неправильной работе может приводить в дедлокам
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetWriter(ReaderWriterLockSlim rwlock)
        {
            return Get(rwlock, LockType.Writer, false);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой записи.
        /// Эскалация блокировки невозможна, что может выражаться в невозможности получить блокировку записи
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetWriterNoEscalate(ReaderWriterLockSlim rwlock)
        {
            return Get(rwlock, LockType.Writer, true);
        }

        private static ReaderWriterLockService Get(ReaderWriterLockSlim rwlock, LockType lockType, bool noEscalate)
        {
            return Get(rwlock, lockType, false, noEscalate);
        }

        #endregion

        #region Получение экземпляра c возможными проверками на наличие установленных ранее блокировок

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой чтения
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <param name="checkHeldLock">Флаг необходимости проверки установленных ранее блокировок</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetReader(ReaderWriterLockSlim rwlock, bool checkHeldLock)
        {
            return Get(rwlock, LockType.Reader, checkHeldLock, true);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой чтения
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <param name="checkHeldLock">Флаг необходимости проверки установленных ранее блокировок</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetUpgradeableReader(ReaderWriterLockSlim rwlock, bool checkHeldLock)
        {
            return Get(rwlock, LockType.UpgradeableReader, checkHeldLock, true);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой записи.
        /// Возможна эскалация блокировки, что при неправильной работе может приводить в дедлокам
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <param name="checkHeldLock">Флаг необходимости проверки установленных ранее блокировок</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetWriter(ReaderWriterLockSlim rwlock, bool checkHeldLock)
        {
            return Get(rwlock, LockType.Writer, checkHeldLock, false);
        }

        /// <summary>
        /// Возвращает экземпляр для работы с блокировкой записи.
        /// Эскалация блокировки невозможна, что может выражаться в невозможности получить блокировку записи
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <param name="checkHeldLock">Флаг необходимости проверки установленных ранее блокировок</param>
        /// <returns>Экземпляр сервиса</returns>
        public static ReaderWriterLockService GetWriterNoEscalate(ReaderWriterLockSlim rwlock, bool checkHeldLock)
        {
            return Get(rwlock, LockType.Writer, checkHeldLock, true);
        }

        private static ReaderWriterLockService Get(ReaderWriterLockSlim rwlock, LockType lockType,
            bool checkHeldLock, bool noEscalate)
        {
            ReaderWriterLockService service = new ReaderWriterLockService(rwlock, lockType, checkHeldLock, noEscalate);
            service.Start();
            return service;
        }

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rwlock">Примитив синхронизации</param>
        /// <param name="lockType">Тип блокировки</param>
        /// <param name="checkHeldLock">Флаг необходимости проверки установленных ранее блокировок</param>
        /// <param name="noEscalate">Флаг, запрещающий эскалацию блокировки</param>
        public ReaderWriterLockService(ReaderWriterLockSlim rwlock, LockType lockType,
            bool checkHeldLock, bool noEscalate)
        {
            this._lock = rwlock;
            this._lockType = lockType;
            this._checkHeldLock = checkHeldLock;
            this._noEscalate = noEscalate;
        }

        /// <summary>
        /// Начало выполнения метода
        /// </summary>
        public void Start()
        {
            if (this._lock == null)
            {
                return;
            }

            if (this._lockType == LockType.Reader)
            {
                if (!this._checkHeldLock || this.HeldNoLock || this.AllowsRecoursive)
                {
                    this._lock.EnterReadLock();
                    this._isStarted = true;
                    return;
                }
            }
            else if (this._lockType == LockType.Writer)
            {
                if (!this._checkHeldLock || this.HeldNoLock || this.AllowsRecoursive ||
                    !this._noEscalate && this._lock.IsUpgradeableReadLockHeld)
                {
                    this._lock.EnterWriteLock();
                    this._isStarted = true;
                    return;
                }
            }
            else if (this._lockType == LockType.UpgradeableReader)
            {
                if (!this._checkHeldLock || this.HeldNoLock || this.AllowsRecoursive)
                {
                    this._lock.EnterUpgradeableReadLock();
                    this._isStarted = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Окончание выполнения метода
        /// </summary>
        public void Finish()
        {
            if (this._isStarted && !this._isFinished)
            {
                if (this._lockType == LockType.Reader)
                {
                    this._lock.ExitReadLock();
                }
                else if (this._lockType == LockType.Writer)
                {
                    this._lock.ExitWriteLock();
                }
                else if (this._lockType == LockType.UpgradeableReader)
                {
                    this._lock.ExitUpgradeableReadLock();
                }
            }
            this._isFinished = true;
        }

        #region IDisposable

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        public virtual void Dispose()
        {
            if (!this._isFinished)
            {
                this.Finish();
            }
        }

        #endregion
    }
}
