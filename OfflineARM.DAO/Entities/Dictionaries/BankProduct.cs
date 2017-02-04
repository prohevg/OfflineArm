namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Банковский продукт
    /// </summary>
    public class BankProduct : BaseDictionaryDaoEntity
    {
        /// <summary>
        /// Банк
        /// </summary>
        public int BankId
        {
            get;
            set;
        }

        /// <summary>
        /// Банк
        /// </summary>
        public Bank Bank
        {
            get;
            set;
        }
    }
}
