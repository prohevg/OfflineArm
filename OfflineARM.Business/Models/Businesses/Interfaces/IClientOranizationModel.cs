using System;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public interface IClientOranizationModel : IBaseDaoEntity
    {
        /// <summary>
        /// Действующего на основании
        /// </summary>
        IBasisActionModel BasisAction
        {
            get;
            set;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        string Name
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

        /// <summary>
        /// В лице
        /// </summary>
        string Face
        {
            get;
            set;
        }

        /// <summary>
        /// Должность
        /// </summary>
        string Position
        {
            get;
            set;
        }

        /// <summary>
        /// Номер документа
        /// </summary>
        string Number
        {
            get;
            set;
        }

        /// <summary>
        /// От
        /// </summary>
        DateTime From
        {
            get;
            set;
        }

        /// <summary>
        /// ИНН
        /// </summary>
        string Inn
        {
            get;
            set;
        }

        /// <summary>
        /// КПП
        /// </summary>
        string Kpp
        {
            get;
            set;
        }
    }
}
