using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfflineARM.Business.Models.Businesses.Interfaces;

namespace OfflineARM.Gui.Forms.Orders.Interfaces
{
    /// <summary>
    /// Контрол с вкладки доставка
    /// </summary>
    public interface IOrderDestinationControl
    {
        /// <summary>
        /// Новая модель физ лица
        /// </summary>
        ICustomerPrivateModel CustomerPrivate
        {
            get;
        }


        /// <summary>
        /// Новая модель юридического лица
        /// </summary>
        ICustomerLegalModel CustomerLegal
        {
            get;
        }
    }
}
