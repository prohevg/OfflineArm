using System;
using OfflineARM.Business.Models.Businesses.Bases;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries.Interfaces;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class CustomerLegalModel : CustomerModel, ICustomerLegalModel
    {
        /// <summary>
        /// Действующего на основании
        /// </summary>
        public IBasisActionModel BasisAction
        {
            get;
            set;
        }

        /// <summary>
        /// В лице
        /// </summary>
        public string Face
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
        /// Номер документа
        /// </summary>
        public string DocNumber
        {
            get;
            set;
        }

        /// <summary>
        /// От
        /// </summary>
        public DateTime DocDate
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
