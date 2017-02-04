using System;
using System.Collections.Generic;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public class Nomenclature : BaseDictionaryDaoEntity
    {
        /// <summary>
        /// Родитель
        /// </summary>
        public int? ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// Родитель
        /// </summary>
        public Nomenclature Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Основной поставщик
        /// </summary>
        public Guid Shipper
        {
            get;
            set;
        }

        /// <summary>
        /// Экспозиция
        /// </summary>
        public virtual ICollection<Exposition> Expositions
        {
            get;
            set;
        }

        /// <summary>
        /// Спецификация заказа
        /// </summary>
        public virtual ICollection<OrderSpecificationItem> OrderSpecifications
        {
            get;
            set;
        }
    }
}
