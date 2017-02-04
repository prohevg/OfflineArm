using System;
using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses.Interfaces
{
    /// <summary>
    /// Клиент юр лицо
    /// </summary>
    public interface ICustomerLegalModel : ICustomerModel
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
        string DocNumber
        {
            get;
            set;
        }

        /// <summary>
        /// От
        /// </summary>
        DateTime DocDate
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
