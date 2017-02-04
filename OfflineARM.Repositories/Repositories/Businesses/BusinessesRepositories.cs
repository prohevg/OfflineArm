using OfflineARM.DAO;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
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

        /// <summary>
        /// Заказ
        /// </summary>
        private IOrderRepository _orderRepository;

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        private IOrderSpecificationItemRepository _orderSpecificationRepository;

        /// <summary>
        /// Оплата картой
        /// </summary>
        private CardPaymentRepository _cardPaymentRepository;

        /// <summary>
        /// Оплата наличными
        /// </summary>
        private CashPaymentRepository _cashPaymentRepository;

        /// <summary>
        /// Оплата кредит
        /// </summary>
        private CreditPaymentRepository _creditPaymentRepository;

        /// <summary>
        ///  Клиент юр лицо
        /// </summary>
        private CustomerLegalRepository _customerLegalRepository;

        /// <summary>
        ///  Клиент физ лицо
        /// </summary>
        private CustomerPrivateRepository _customerPrivateRepository;

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

        /// <summary>  
        /// Репозиторий Заказ  
        /// </summary>  
        public IOrderRepository OrderRepository
        {
            get
            {
                if (this._orderRepository == null)
                {
                    this._orderRepository = new OrderRepository(_context);
                }
                return _orderRepository;
            }
        }

        /// <summary>  
        /// Репозиторий Спецификация заказа  
        /// </summary>  
        public IOrderSpecificationItemRepository OrderSpecificationRepository
        {
            get
            {
                if (this._orderSpecificationRepository == null)
                {
                    this._orderSpecificationRepository = new OrderSpecificationItemRepository(_context);
                }
                return _orderSpecificationRepository;
            }
        }

        /// <summary>
        /// Оплата картой
        /// </summary>
        public ICardPaymentRepository CardPaymentRepository
        {
            get
            {
                if (this._cardPaymentRepository == null)
                {
                    this._cardPaymentRepository = new CardPaymentRepository(_context);
                }
                return _cardPaymentRepository;
            }
        }

        /// <summary>
        /// Оплата наличными
        /// </summary>
        public ICashPaymentRepository CashPaymentRepository
        {
            get
            {
                if (this._cashPaymentRepository == null)
                {
                    this._cashPaymentRepository = new CashPaymentRepository(_context);
                }
                return _cashPaymentRepository;
            }
        }

        /// <summary>
        /// Оплата кредит
        /// </summary>
        public ICreditPaymentRepository CreditPaymentRepository
        {
            get
            {
                if (this._creditPaymentRepository == null)
                {
                    this._creditPaymentRepository = new CreditPaymentRepository(_context);
                }
                return _creditPaymentRepository;
            }
        }

        /// <summary>
        ///  Клиент юр лицо
        /// </summary>
        public ICustomerLegalRepository CustomerLegalRepository
        {
            get
            {
                if (this._customerLegalRepository == null)
                {
                    this._customerLegalRepository = new CustomerLegalRepository(_context);
                }
                return _customerLegalRepository;
            }
        }

        /// <summary>
        ///  Клиент физ лицо
        /// </summary>
        public ICustomerPrivateRepository CustomerPrivateRepository
        {
            get
            {
                if (this._customerPrivateRepository == null)
                {
                    this._customerPrivateRepository = new CustomerPrivateRepository(_context);
                }
                return _customerPrivateRepository;
            }
        }

        #endregion
    }
}
