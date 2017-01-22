using System;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Сумка для инкассации
    /// </summary>
    public class BagCollection : BaseDaoEntity
    {
        /// <summary>
        ///  Магазин\салон
        /// </summary>
        public int ShopId
        {
            get;
            set;
        }

        /// <summary>
        ///  Магазин\салон
        /// </summary>
        public Shop Shop
        {
            get;
            set;
        }

        /// <summary>
        /// Отделение
        /// </summary>
        public Guid Department
        {
            get;
            set;
        }

        /// <summary>
        /// Ответственный
        /// </summary>
        public Guid Responsible
        {
            get;
            set;
        }
    }
}
