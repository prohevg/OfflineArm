using System;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public class OrderSpecificationItem : BaseDaoEntity
    {
        /// <summary>
        /// Заказ
        /// </summary>
        public int OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// Заказ
        /// </summary>
        public Order Order
        {
            get;
            set;
        }

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
        public int FeatureId
        {
            get;
            set;
        }

        /// <summary>
        /// Характеристика
        /// </summary>
        public Feature Feature
        {
            get;
            set;
        }

        /// <summary>
        /// Кол-во
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
        public decimal DiscountPercent
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        public decimal PriceWithDiscount
        {
            get;
            set;
        }
    }
}
