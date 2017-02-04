using System;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public class OrderSpecificationItemModel : BaseBusninessModel, IOrderSpecificationItemModel
    {
        /// <summary>
        /// Заказ
        /// </summary>
        public IOrderModel Order
        {
            get;
            set;
        }

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
