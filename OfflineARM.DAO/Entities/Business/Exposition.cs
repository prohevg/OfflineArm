using OfflineARM.DAO.Entities.Dictionaries;

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
        public int FeatureId
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public Feature Feature
        {
            get;
            set;
        }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price
        {
            get;
            set;
        }

        /// <summary>
        /// Количество
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
