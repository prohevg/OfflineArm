using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Банковский продукт
    /// </summary>
    public class BankProductModel : BaseBusninessModel, IBankProductModel
    {
        /// <summary>
        /// Банк
        /// </summary>
        public IBankModel Bank
        {
            get;
            set;
        }

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
