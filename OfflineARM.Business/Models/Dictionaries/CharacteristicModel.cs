using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public class CharacteristicModel : BaseBusninessModel,  ICharacteristicModel
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
        /// Цена
        /// </summary>
        public decimal Price
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
