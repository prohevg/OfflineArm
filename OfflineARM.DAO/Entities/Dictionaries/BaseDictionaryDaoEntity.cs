namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Базовая сущность для всех сущностей БД
    /// </summary>
    public abstract class BaseDictionaryDaoEntity : BaseDaoEntity
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
