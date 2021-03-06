﻿using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.Repositories.Repositories.Businesses.Interfaces;

namespace OfflineARM.Repositories.Repositories.Businesses
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public class CashPaymentRepository : BaseRepository<CashPayment>, ICashPaymentRepository
    {
        #region Конструктор

        /// <summary>  
        /// Конструктор  
        /// </summary>  
        /// <param name="context">Контекст выполнения БД</param>  
        public CashPaymentRepository(ApplicationDbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
