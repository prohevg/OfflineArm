using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Форма клиента юридического лица
    /// </summary>
    public interface ICustomerLegalForm
    {
        /// <summary>
        /// Новая модель юридического лица
        /// </summary>
        ICustomerLegalModel CustomerLegal { get; set; }
    }
}
