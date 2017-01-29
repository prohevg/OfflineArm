using System;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public class OrderSpecification : BaseDaoEntity
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
        public int CharacteristicId
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public Characteristic Characteristic
        {
            get;
            set;
        }

        /// <summary>
        /// Склад
        /// </summary>
        public Guid Stock
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
        /// Цена
        /// </summary>
        public decimal Price
        {
            get;
            set;
        }

        /// <summary>
        /// % скидки
        /// </summary>
        public decimal DiscountProcent
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum
        {
            get;
            set;
        }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public decimal TotalSum
        {
            get;
            set;
        }
    }
}
