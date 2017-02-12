using System;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Base;
using OfflineARM.DAO;
using OfflineARM.DAO.Entities.Dictionaries;

namespace OfflineARM.Controller.ViewInterfaces.Orders
{
    /// <summary>
    /// Форма клиента юридического лица
    /// </summary>
    public interface ICustomerLegalView : IBaseView<ICustomerLegalController>
    {
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
        /// Действующего на основании
        /// </summary>
        BasisAction BasisAction
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

        /// <summary>
        /// Загрузить действия
        /// </summary>
        /// <param name="listActions"></param>
        void LoadActions(PagedResult<BasisAction> listActions);

        /// <summary>
        /// Открыть окно
        /// </summary>
        void ShowDialog();
    }
}
