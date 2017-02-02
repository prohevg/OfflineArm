using OfflineARM.DAO.Entities;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public interface IClientPrivateModel : IBaseDaoEntity
    {
        /// <summary>
        /// ФИО
        /// </summary>
        string FIO
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        string Phone
        {
            get;
            set;
        }
    }
}
