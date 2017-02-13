using Ninject;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Orders;
using OfflineARM.Controller.ViewInterfaces.Settings;
using OfflineARM.View.Views.Orders;
using OfflineARM.View.Views.Settings;

namespace OfflineARM.View
{
    /// <summary>
    /// Контайнер форм
    /// </summary>
    public class IoCView
    {
        #region поля и свойства

        /// <summary>
        /// Контейнер
        /// </summary>
        private IKernel _container;

        /// <summary>
        /// Instance
        /// </summary>
        public static readonly IoCView Instance = new IoCView();

        #endregion

        #region public

        /// <summary>
        /// Регистрация моделей
        /// </summary>
        /// <param name="container">Контейнер</param>
        public void Register(IKernel container = null)
        {
            this._container = container ?? new StandardKernel();

            RegisterForm(container);
        }

        /// <summary>
        /// Получить
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        public TClass Resolve<TClass>() where TClass : class
        {
            return _container.Get<TClass>();
        }

        #endregion

        #region private

        /// <summary>
        /// Формы
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterForm(IKernel container)
        {
            container.Bind<IMainView>().To<MainView>();
            container.Bind<IAutorizationView>().To<AutorizationView>();
            container.Bind<IAboutBoxProgramView>().To<AboutBoxProgramView>();
            container.Bind<IMessageBoxView>().To<MessageBoxView>();

            #region orders

            container.Bind<IOrderListView>().To<OrderListView>();
            container.Bind<IOrderEditView>().To<OrderEditView>();
            container.Bind<IOrderPartSpecificView>().To<OrderPartSpecificView>();
            container.Bind<IOrderPartDeliveryView>().To<OrderPartDeliveryView>();
            container.Bind<IOrderPartPayView>().To<OrderPartPayView>();

            container.Bind<ICustomerPrivateView>().To<CustomerPrivateView>();
            container.Bind<ICustomerLegalView>().To<CustomerLegalView>();
            container.Bind<IOrderAddressView>().To<OrderAddressView>();

            #endregion

            #region settings

            container.Bind<ISettingsView>().To<SettingsView>();
            container.Bind<ISettingApplicationView>().To<SettingApplicationView>();

            #endregion
        }

        #endregion
    }
}
