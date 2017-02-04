using System;
using OfflineARM.DAO.Entities.Business.Bases;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Клиент юр лицо
    /// </summary>
    public class CustomerLegal : Customer
    {
        /// <summary>
        ///  Действующего на основании
        /// </summary>
        public int BasisActionId
        {
            get;
            set;
        }

        /// <summary>
        /// Действующего на основании
        /// </summary>
        public BasisAction BasisAction
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
