using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Оплата кредит
    /// </summary>
    public class CreditPaymentRepository : BaseRepository<CreditPayment>, ICreditPaymentRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CreditPaymentRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
