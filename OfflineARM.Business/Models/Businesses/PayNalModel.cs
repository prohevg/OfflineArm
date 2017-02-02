using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public class PayNalModel : BaseDaoEntity, IPayNalModel
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

        public static implicit operator PayNalModel(PayNal value)
        {
            var result = new PayNalModel
            {
                Id = value.Id,
                Guid = value.Guid,
                Summ = value.Summ,
                Number = value.Number,
                IsInputManual = value.IsInputManual
            };
            return result;
        }

        public static implicit operator PayNal(PayNalModel value)
        {
            var result = new PayNal
            {
                Id = value.Id,
                Guid = value.Guid,
                Summ = value.Summ,
                Number = value.Number,
                IsInputManual = value.IsInputManual
            };
            return result;
        }

        #endregion
    }
}
