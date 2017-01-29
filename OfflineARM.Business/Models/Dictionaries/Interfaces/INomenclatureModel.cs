using System.Collections.Generic;

namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Модель номенклатуры
    /// </summary>
    public interface INomenclatureModel : IBaseBusninessModel
    {
        /// <summary>
        /// Родительский узел
        /// </summary>
        int ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// Родительский узел
        /// </summary>
        INomenclatureModel Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Дочерние узлы
        /// </summary>
        List<INomenclatureModel> Childs
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
