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
        private ICharacteristicRepository _characteristicRepository;

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
        public ICharacteristicRepository CharacteristicRepository
        {
            get
            {
                if (this._characteristicRepository == null)
                {
                    this._characteristicRepository = new CharacteristicRepository(_context);
                }
                return _characteristicRepository;
            }
        }


        #endregion
    }
}
