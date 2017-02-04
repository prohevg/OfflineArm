namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Банк
    /// </summary>
    public interface IBankModel : IBaseBusninessModel
    {
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
