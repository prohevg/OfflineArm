using System;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public class Nomenclature : BaseDaoEntity
    {
        /// <summary>
        /// Родитель
        /// </summary>
        public int ParentId
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
        /// Наименование
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
