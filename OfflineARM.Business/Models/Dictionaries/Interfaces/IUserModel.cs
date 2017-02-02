using System;

namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public interface IUserModel : IBaseBusninessModel
    {
        /// <summary>
        /// Должность
        /// </summary>
        Guid Position
        {
            get;
            set;
        }

        /// <summary>
        /// Магазин\салон
        /// </summary>
        IShopModel Shop
        {
            get;
            set;
        }

        /// <summary>
        /// ФИО
        /// </summary>
        string Fio
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        string Email
        {
            get;
            set;
        }
    }
}
