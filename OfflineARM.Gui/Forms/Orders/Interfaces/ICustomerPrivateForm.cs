using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Форма создания клиента
    /// </summary>
    public interface ICustomerPrivateForm
    {
        /// <summary>
        /// Новая модель физ лица
        /// </summary>
        ICustomerPrivateModel CustomerPrivate { get; set; }
    }
}
