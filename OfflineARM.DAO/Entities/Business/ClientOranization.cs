using System;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.DAO.Entities.Business
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class ClientOranization : BaseDaoEntity
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
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// От
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
