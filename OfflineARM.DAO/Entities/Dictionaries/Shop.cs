using System;
using OfflineARM.DAO.Entities.Business;

namespace OfflineARM.DAO.Entities.Dictionaries
{
    /// <summary>
    /// Магазин\салон
    /// </summary>
    public class Shop : BaseDaoEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Город
        /// </summary>
        public int CityId
        {
            get;
            set;
        }

        /// <summary>
        /// Город
        /// </summary>
        public City City
        {
            get;
            set;
        }

        /// <summary>
        /// Организация
        /// </summary>
        public int OrganizationId
        {
            get;
            set;
        }


        /// <summary>
        /// Организация
        /// </summary>
        public Organization Organization
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
    }
}
