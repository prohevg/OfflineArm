namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Действующего на основании
    /// </summary>
    public interface IBasisActionModel : IBaseBusninessModel
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
