using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Спецификация заказа
    /// </summary>
    public interface IOrderSpecificationItemModel : IBaseBusninessModel
    {
        /// <summary>
        /// Заказ
        /// </summary>
        IOrderModel Order
        {
            get;
            set;
        }

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
        IFeatureModel Feature
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
        /// % скидки
        /// </summary>
        decimal DiscountPercent
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма скидки
        /// </summary>
        decimal DiscountAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Итоговая сумма
        /// </summary>
        decimal PriceWithDiscount
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
    }
}
