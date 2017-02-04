using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public class CardPaymentRepository : BaseRepository<CardPayment>, ICardPaymentRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CardPaymentRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
