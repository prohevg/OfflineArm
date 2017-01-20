using System;

namespace OfflineARM.DAO.Entities
{
    /// <summary>
    /// Базовая сущность для всех сущностей БД
    /// </summary>
    public interface IBaseDaoEntity
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
        /// Guid из 1С  
        /// </summary>
        Guid Guid
        {
            get;
            set;
        }
    }
}
