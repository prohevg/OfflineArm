using System;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public class Exposition : BaseDaoEntity
    {
        /// <summary>
        /// Номенклатура
        /// </summary>
        public int NomenclatureId
        {
            get;
            set;
        }

        /// <summary>
        /// Номенклатура
        /// </summary>
        public Nomenclature Nomenclature
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public int CharacteristicId
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public Characteristic Characteristic
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Доступно к продаже
        /// </summary>
        public bool IsEnabled
        {
            get;
            set;
        }
    }
}
