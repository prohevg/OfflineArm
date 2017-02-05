using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Контрол клиент
    /// </summary>
    internal interface IOrderCustomerControl
    {
        /// <summary>
        /// Новая модель физ лица
        /// </summary>
        ICustomerPrivateModel CustomerPrivate
        {
            get;
            set;
        }


        /// <summary>
        /// Новая модель юридического лица
        /// </summary>
        ICustomerLegalModel CustomerLegal
        {
            get;
            set;
        }
    }
}