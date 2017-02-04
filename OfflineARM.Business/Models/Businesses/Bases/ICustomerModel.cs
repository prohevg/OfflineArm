namespace OfflineARM.Business.Models.Businesses.Bases
{
    /// <summary>
    /// Базовый тип покупателя
    /// </summary>
    public interface ICustomerModel : IBaseBusninessModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес
        /// </summary>
        string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон
        /// </summary>
        string Phone
        {
            get;
            set;
        }
    }
}
