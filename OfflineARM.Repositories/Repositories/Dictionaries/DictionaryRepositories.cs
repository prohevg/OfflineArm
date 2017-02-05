using OfflineARM.DAO;
using OfflineARM.Repositories.Repositories.Dictionaries.Interfaces;

namespace OfflineARM.Repositories.Repositories.Dictionaries
{
    /// <summary>
    /// Список справочников
    /// </summary>
    public class DictionaryRepositories : IDictionaryRepositories
    {
        #region поля и свойства

        /// <summary>
        /// Контекст выполнения БД
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Репозиторий Города
        /// </summary>
        private ICityRepository _cityRepository;

        /// <summary>
        /// Репозиторий Местонахождениe
        /// </summary>
        private ILocationRepository _locationRepository;

        /// <summary>
        /// Репозиторий Действующего на основании
        /// </summary>
        private IBasisActionRepository _basisActionRepository;

        /// <summary>
        /// Репозиторий Требование клиента
        /// </summary>
        private ICustomerRequirementRepository _customerRequirementRepository;

        /// <summary>
        /// Репозиторий Статус заказа
        /// </summary>
        private IOrderStatusRepository _orderStatusRepository;

        /// <summary>
        /// Репозиторий Номенклатура
        /// </summary>
        private INomenclatureRepository _nomenclatureRepository;

        /// <summary>
        /// Репозиторий Характеристика номенклатуры
        /// </summary>
        private IFeatureRepository _featureRepository;

        /// <summary>
        /// Репозиторий Банк
        /// </summary>
        private IBankRepository _bankRepository;

        /// <summary>
        /// Репозиторий Банковский продукт
        /// </summary>
        private IBankProductRepository _bankProductRepository;

        /// <summary>  
        /// Группа номенклатур
        /// </summary>  
        private INomenclatureGroupRepository _nomenclatureGroupRepository;

        /// <summary>
        /// Пользователь
        /// </summary>
        private UserRepository _userRepository;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public DictionaryRepositories(ApplicationDbContext context)
        {
            _context = context;
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

        /// <summary>  
        /// Репозиторий Местонахождениe  
        /// </summary>  
        public ILocationRepository LocationRepository
        {
            get
            {
                if (this._locationRepository == null)
                {
                    this._locationRepository = new LocationRepository(_context);
                }
                return _locationRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Действующего на основании  
        /// </summary>  
        public IBasisActionRepository BasisActionRepository
        {
            get
            {
                if (this._basisActionRepository == null)
                {
                    this._basisActionRepository = new BasisActionRepository(_context);
                }
                return _basisActionRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Требование клиента
        /// </summary>  
        public ICustomerRequirementRepository CustomerRequirementRepository
        {
            get
            {
                if (this._customerRequirementRepository == null)
                {
                    this._customerRequirementRepository = new CustomerRequirementRepository(_context);
                }
                return _customerRequirementRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Статус заказа
        /// </summary>  
        public IOrderStatusRepository OrderStatusRepository
        {
            get
            {
                if (this._orderStatusRepository == null)
                {
                    this._orderStatusRepository = new OrderStatusRepository(_context);
                }
                return _orderStatusRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Номенклатура
        /// </summary>  
        public INomenclatureRepository NomenclatureRepository
        {
            get
            {
                if (this._nomenclatureRepository == null)
                {
                    this._nomenclatureRepository = new NomenclatureRepository(_context);
                }
                return _nomenclatureRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Характеристика номенклатуры
        /// </summary>  
        public IFeatureRepository FeatureRepository
        {
            get
            {
                if (this._featureRepository == null)
                {
                    this._featureRepository = new FeatureRepository(_context);
                }
                return _featureRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Банк
        /// </summary>  
        public IBankRepository BankRepository
        {
            get
            {
                if (this._bankRepository == null)
                {
                    this._bankRepository = new BankRepository(_context);
                }
                return _bankRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Банковский продукт
        /// </summary>  
        public IBankProductRepository BankProductRepository
        {
            get
            {
                if (this._bankProductRepository == null)
                {
                    this._bankProductRepository = new BankProductRepository(_context);
                }
                return _bankProductRepository;
            }
        }

        /// <summary>  
        /// Группа номенклатур
        /// </summary>  
        public INomenclatureGroupRepository NomenclatureGroupRepository
        {
            get
            {
                if (this._nomenclatureGroupRepository == null)
                {
                    this._nomenclatureGroupRepository = new NomenclatureGroupRepository(_context);
                }
                return _nomenclatureGroupRepository;
            }
        }

        /// <summary>  
        /// Пользователь
        /// </summary>  
        public IUserRepository UserRepository
        {
            get
            {
                if (this._userRepository == null)
                {
                    this._userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        #endregion
    }
}
