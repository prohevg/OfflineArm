using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class ClientPrivateModel : BaseDaoEntity, IClientPrivateModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone
        {
            get;
            set;
        }

        #region implicit

        public static implicit operator ClientPrivateModel(ClientPrivate value)
        {
            var result = new ClientPrivateModel
            {
                Id = value.Id,
                Guid = value.Guid,
                FIO = value.FIO,
                Address = value.Address,
                Phone = value.Phone,
            };

            return result;
        }

        public static implicit operator ClientPrivate(ClientPrivateModel value)
        {
            var result = new ClientPrivate
            {
                Id = value.Id,
                Guid = value.Guid,
                FIO = value.FIO,
                Address = value.Address,
                Phone = value.Phone,
            };

            return result;
        }

        #endregion
    }
}
