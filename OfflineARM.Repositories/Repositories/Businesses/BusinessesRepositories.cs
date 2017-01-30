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
        private IOrderSpecificationRepository _orderSpecificationRepository;

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
        public IOrderSpecificationRepository OrderSpecificationRepository
        {
            get
            {
                if (this._orderSpecificationRepository == null)
                {
                    this._orderSpecificationRepository = new OrderSpecificationRepository(_context);
                }
                return _orderSpecificationRepository;
            }
        }


        #endregion
    }
}
