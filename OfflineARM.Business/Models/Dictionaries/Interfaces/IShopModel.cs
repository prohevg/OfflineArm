using System;

namespace OfflineARM.Business.Models.Dictionaries.Interfaces
{
    /// <summary>
    /// Магазин\салон
    /// </summary>
    public interface IShopModel : IBaseBusninessModel
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
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Касса
        /// </summary>
        Guid Cashbox
        {
            get;
            set;
        }

        /// <summary>
        /// Основной склад
        /// </summary>
        Guid WarehouseMain
        {
            get;
            set;
        }

        /// <summary>
        /// Склад ЭКСПО(салон) 
        /// </summary>
        Guid WarehouseEkspo
        {
            get;
            set;
        }

        /// <summary>
        /// Склад ЭКСПО(салон) 
        /// </summary>
        Guid WarehouseStock
        {
            get;
            set;
        }

        /// <summary>
        /// Адрес 
        /// </summary>
        string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Телефон 
        /// </summary>
        string Phone
        {
            get;
            set;
        }
    }
}
