using System;

namespace OfflineARM.Business.Models
{
    /// <summary>
    /// Базовая сущность для всех сущностей моделей
    /// </summary>
    public abstract class BaseBusninessModel : IBaseBusninessModel
    {
        /// <summary>
        /// Id в БД
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Guid в БД
        /// </summary>
        public Guid Guid
        {
            get;
            set;
        }
    }
}
