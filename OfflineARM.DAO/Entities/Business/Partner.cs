using System;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Контрагент
    /// </summary>
    public class Partner : BaseDaoEntity
    {
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
        /// Местоположение
        /// </summary>
        public int LocationId
        {
            get;
            set;
        }

        /// <summary>
        /// Местоположение
        /// </summary>
        public Location Location
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

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string LegalAddress
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

        /// <summary>
        /// В лице
        /// </summary>
        public string Person
        {
            get;
            set;
        }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position
        {
            get;
            set;
        }

        /// <summary>
        /// Действующего на основании
        /// </summary>
        public string BasisAction
        {
            get;
            set;
        }

        /// <summary>
        /// Номер
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// От(дата)
        /// </summary>
        public DateTime From
        {
            get;
            set;
        }

        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn
        {
            get;
            set;
        }

        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp
        {
            get;
            set;
        }
    }
}
