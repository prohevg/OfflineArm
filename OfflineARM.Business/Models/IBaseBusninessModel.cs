using System;

namespace OfflineARM.Business.Models
{
    /// <summary>
    /// Базовая сущность для всех сущностей в сервисе
    /// </summary>
    public interface IBaseBusninessModel
    {
        /// <summary>
        /// Id в БД
        /// </summary>
        int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Guid в БД
        /// </summary>
        Guid Guid
        {
            get;
            set;
        }
    }
}
