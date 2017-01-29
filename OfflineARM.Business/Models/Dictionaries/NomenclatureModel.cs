using System.Collections.Generic;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Модель номенклатуры
    /// </summary>
    public class NomenclatureModel : BaseBusninessModel, INomenclatureModel
    {
        /// <summary>
        /// Дочерние узлы
        /// </summary>
        private List<INomenclatureModel> _childs = new List<INomenclatureModel>();

        /// <summary>
        /// Родительский узел
        /// </summary>
        public int ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// Родительский узел
        /// </summary>
        public INomenclatureModel Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Дочерние узлы
        /// </summary>
        public List<INomenclatureModel> Childs
        {
            get
            {
                return _childs;
            }
            set
            {
                _childs = value;
            }
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
