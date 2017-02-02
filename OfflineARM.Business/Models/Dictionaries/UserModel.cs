using System;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserModel : BaseBusninessModel, IUserModel
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
        public IShopModel Shop
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

        #region implicit

        public static implicit operator UserModel(User value)
        {
            var result = new UserModel
            {
                Id = value.Id,
                Guid = value.Guid,
                Position = value.Position,
                Fio = value.Fio,
                Login = value.Login,
                Password = value.Password,
                Email = value.Email,
            };

            if (value.Shop != null)
            {
                //result.Shop = ()
            }

            return result;
        }

        public static implicit operator User(UserModel value)
        {
            var result = new User
            {
                Id = value.Id,
                Guid = value.Guid,
                Position = value.Position,
                Fio = value.Fio,
                Login = value.Login,
                Password = value.Password,
                Email = value.Email,
            };

            //if (value.Shop != null)
            //{
            //      result.Shop = 
            //}

            return result;
        }

        #endregion
    }
}
