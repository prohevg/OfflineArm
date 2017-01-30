using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Business.Models.Dictionaries.Interfaces
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
