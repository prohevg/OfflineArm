using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public class ExpositionModel : BaseBusninessModel, IExpositionModel
    {
        /// <summary>
        /// Номенклатура
        /// </summary>
        public INomenclatureModel Nomenclature
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public IFeatureModel Feature
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
