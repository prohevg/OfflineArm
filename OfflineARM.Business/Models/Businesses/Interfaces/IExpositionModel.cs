using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Экспозиция
    /// </summary>
    public interface IExpositionModel : IBaseBusninessModel
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
        /// Характеристика
        /// </summary>
        ICharacteristicModel Characteristic
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
        /// Количество
        /// </summary>
        int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Доступно к продаже
        /// </summary>
        bool IsEnabled
        {
            get;
            set;
        }
    }
}
