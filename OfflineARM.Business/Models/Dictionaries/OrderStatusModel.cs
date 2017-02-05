using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public class OrderStatusModel : BaseBusninessModel, IOrderStatusModel
    {
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
