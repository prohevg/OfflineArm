namespace OfflineARM.Business.Models.Businesses.Bases
{
    /// <summary>
    /// Базовый тип покупателя
    /// </summary>
    public abstract class CustomerModel : BaseBusninessModel, ICustomerModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone
        {
            get;
            set;
        }
    }
}
