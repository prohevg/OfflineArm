using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.View.Base.Controls;

namespace OfflineARM.View.Views.Orders
{
    /// <summary>
    /// Контрол адрес доставки
    /// </summary>
    public partial class OrderPartDeliveryView : BasePartControlView<IOrderPartDeliveryController>, IOrderPartDeliveryView
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public OrderPartDeliveryView()
        {
            InitializeComponent();

            this.Controller.SetControllers(this.orderClient.Controller, this.orderAddress.Controller);
        }

        #endregion

        #region IOrderPartDeliveryView


        ///// <summary>
        ///// модель физ лица
        ///// </summary>
        //public ICustomerPrivateModel CustomerPrivate
        //{
        //    get
        //    {
        //        return this.orderClient.CustomerPrivate;
        //    }
        //}

        ///// <summary>
        ///// модель юридического лица
        ///// </summary>
        //public ICustomerLegalModel CustomerLegal
        //{
        //    get
        //    {
        //        return this.orderClient.CustomerLegal;
        //    }
        //}

        ///// <summary>
        ///// Адрес
        ///// </summary>
        //public IDeliveryModel Delivery
        //{
        //    get
        //    {
        //        return this.orderAddress.Delivery;
        //    }
        //}

        #endregion
    }
}
