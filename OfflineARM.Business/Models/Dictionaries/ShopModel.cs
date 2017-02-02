using System;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Business.Models.Dictionaries
{
    /// <summary>
    /// Магазин\салон
    /// </summary>
    public class ShopModel : BaseBusninessModel, IShopModel
    {
        ///// <summary>
        ///// Город
        ///// </summary>
        //public City City
        //{
        //    get;
        //    set;
        //}

        ///// <summary>
        ///// Организация
        ///// </summary>
        //public Organization Organization
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Касса
        /// </summary>
        public Guid Cashbox
        {
            get;
            set;
        }

        /// <summary>
        /// Основной склад
        /// </summary>
        public Guid WarehouseMain
        {
            get;
            set;
        }

        /// <summary>
        /// Склад ЭКСПО(салон) 
        /// </summary>
        public Guid WarehouseEkspo
        {
            get;
            set;
        }

        /// <summary>
        /// Склад ЭКСПО(салон) 
        /// </summary>
        public Guid WarehouseStock
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес 
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон 
        /// </summary>
        public string Phone
        {
            get;
            set;
        }

        #region implicit


        public static implicit operator ShopModel(Shop value)
        {
            var result = new ShopModel
            {
                Id = value.Id,
                Guid = value.Guid,
                Name = value.Name,
                Cashbox = value.Cashbox,
                WarehouseMain = value.WarehouseMain,
                WarehouseEkspo = value.WarehouseEkspo,
                WarehouseStock = value.WarehouseStock,
                Address = value.Address,
                Phone = value.Phone,
            };

            //if (value.Shop != null)
            //{
            //    //   result.Shop = 
            //}

            return result;
        }

        public static implicit operator Shop(ShopModel value)
        {
            var result = new Shop
            {
                Id = value.Id,
                Guid = value.Guid,
                Name = value.Name,
                Cashbox = value.Cashbox,
                WarehouseMain = value.WarehouseMain,
                WarehouseEkspo = value.WarehouseEkspo,
                WarehouseStock = value.WarehouseStock,
                Address = value.Address,
                Phone = value.Phone,
            };

            //if (value.Shop != null)
            //{
            //    //   result.Shop = 
            //}

            return result;
        }

        #endregion
    }
}
