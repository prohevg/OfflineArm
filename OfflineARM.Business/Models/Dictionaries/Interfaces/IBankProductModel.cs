namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Банковский продукт
    /// </summary>
    public interface IBankProductModel : IBaseBusninessModel
    {
        /// <summary>
        /// Банк
        /// </summary>
        IBankModel Bank
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}
