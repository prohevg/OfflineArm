using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата картой
    /// </summary>
    public class PayCardModel : BaseDaoEntity, IPayCardModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public decimal Summ
        {
            get;
            set;
        }

        /// <summary>
        /// Номер чека
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        public bool IsInputManual
        {
            get;
            set;
        }

        #region implicit

        public static implicit operator PayCardModel(PayCard value)
        {
            var result = new PayCardModel
            {
                Id = value.Id,
                Guid = value.Guid,
                IsInputManual = value.IsInputManual,
                Number = value.Number,
                Summ = value.Summ
            };
            return result;
        }

        public static implicit operator PayCard(PayCardModel value)
        {
            var result = new PayCard
            {
                Id = value.Id,
                Guid = value.Guid,
                IsInputManual = value.IsInputManual,
                Number = value.Number,
                Summ = value.Summ
            };
            return result;
        }

        #endregion
    }
}
