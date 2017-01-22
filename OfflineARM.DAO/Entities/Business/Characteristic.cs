using System.ComponentModel.DataAnnotations.Schema;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Характеристика номенклатуры
    /// </summary>
    public class Characteristic : BaseDaoEntity
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
