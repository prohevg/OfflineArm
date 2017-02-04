namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public class Feature : BaseDictionaryDaoEntity
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
        /// Цена
        /// </summary>
        public decimal Price
        {
            get;
            set;
        }
    }
}
