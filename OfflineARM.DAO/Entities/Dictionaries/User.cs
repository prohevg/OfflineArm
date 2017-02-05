using System;

namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : BaseDaoEntity
    {
        /// <summary>
        /// Должность
        /// </summary>
        public Guid Position
        {
            get;
            set;
        }

        /// <summary>
        /// Магазин\салон
        /// </summary>
        public int ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// Магазин\салон
        /// </summary>
        public Shop Shop
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Fio
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }
    }
}
