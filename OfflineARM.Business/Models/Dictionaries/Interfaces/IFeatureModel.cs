namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public interface IFeatureModel : IBaseBusninessModel
    {
        /// <summary>
        /// Номенклатура
        /// </summary>
        INomenclatureModel Nomenclature
        {
            get;
            set;
        }

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}
