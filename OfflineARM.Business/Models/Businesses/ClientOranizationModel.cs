using System;
using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Models.Dictionaries;
using OfflineARM.Business.Models.Dictionaries.Interfaces;
using OfflineARM.DAO.Entities;
using OfflineARM.DAO.Entities.Business;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Business.Models.Businesses
{
    /// <summary>
    /// Клиент физ лицо
    /// </summary>
    public class ClientOranizationModel : BaseDaoEntity, IClientOranizationModel
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

        #region implicit

        public static implicit operator ClientOranizationModel(ClientOranization value)
        {
            var result = new ClientOranizationModel
            {
                Id = value.Id,
                Guid = value.Guid,
                Name = value.Name,
                Address = value.Address,
                Phone = value.Phone,
                Face = value.Face,
                Position = value.Position,
                Number = value.Number,
                From = value.From,
                Inn = value.Inn,
                Kpp = value.Kpp,
            };

            if (value.BasisAction != null)
            {
                result.BasisAction = (BasisActionModel)value.BasisAction;
            }

            return result;
        }

        public static implicit operator ClientOranization(ClientOranizationModel value)
        {
            var result = new ClientOranization
            {
                Id = value.Id,
                Guid = value.Guid,
                Name = value.Name,
                Address = value.Address,
                Phone = value.Phone,
                Face = value.Face,
                Position = value.Position,
                Number = value.Number,
                From = value.From,
                Inn = value.Inn,
                Kpp = value.Kpp,
            };

            if (value.BasisAction != null)
            {
                result.BasisAction = (BasisAction)value.BasisAction;
            }

            return result;
        }

        #endregion
    }
}
