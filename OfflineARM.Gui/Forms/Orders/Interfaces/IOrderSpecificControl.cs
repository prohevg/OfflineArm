using System.Collections.Generic;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Спецификация товара
    /// </summary>
    public interface IOrderSpecificControl
    {
        /// <summary>
        /// Список спецификации
        /// </summary>
        List<IOrderSpecificationItemModel> Specifications
        {
            get;
            set;
        }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        decimal TotalAmount
        {
            get;
            set;
        }
    }
}
