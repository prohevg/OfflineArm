using OfflineARM.DAO.Entities;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Оплата наличными
    /// </summary>
    public interface IPayNalModel : IBaseDaoEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        decimal Summ
        {
            get;
            set;
        }

        /// <summary>
        /// Номер чека
        /// </summary>
        string Number
        {
            get;
            set;
        }

        /// <summary>
        /// Чек пробит вручную
        /// </summary>
        bool IsInputManual
        {
            get;
            set;
        }
    }
}
