using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Действующего на основании
    /// </summary>
    public class BasisActionModel : BaseBusninessModel, IBasisActionModel
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
