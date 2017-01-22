using System;

namespace OfflineARM.DAO.Entities
{
    /// <summary>
    /// Базовая сущность для всех сущностей БД
    /// </summary>
    public abstract class BaseDaoEntity : IBaseDaoEntity
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
        /// Guid из 1С   
        /// </summary>
        public Guid Guid
        {
            get;
            set;
        }
    }
}
