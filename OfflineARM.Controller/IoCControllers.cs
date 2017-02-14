using System;
using Ninject;
using Ninject.Parameters;
using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ControllerInterfaces.Orders;
using OfflineARM.Controller.ControllerInterfaces.Settings;
using OfflineARM.Controller.Controllers;
using OfflineARM.Controller.Controllers.Orders;
using OfflineARM.Controller.Controllers.Settings;
using OfflineARM.Controller.CustomConfigFile;
using OfflineARM.Controller.Validators.Businesses;
using OfflineARM.Controller.Validators.Businesses.Interfaces;
using OfflineARM.Controller.Validators.Dictionaries;
using OfflineARM.Controller.Validators.Dictionaries.Interfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller
{
    /// <summary>
    /// Регистрация компонент логики
    /// </summary>
    public class IoCControllers
    {
        #region поля и свойства

        /// <summary>
        /// Контейнер
        /// </summary>
        private IKernel _container;

        /// <summary>
        /// Instance
        /// </summary>
        public static readonly IoCControllers Instance = new IoCControllers();

        #endregion

        #region public

        /// <summary>
        /// Регистрация моделей
        /// </summary>
        /// <param name="container">Контейнер</param>
        public void Register(IKernel container = null)
        {
            this._container = container ?? new StandardKernel();

            RegisterImp(container);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        public TClass Get<TClass>() where TClass : class
        {
            return _container.Get<TClass>();
        }

        /// <summary>
        ///  Получить Controller
        /// </summary>
        /// <typeparam name="TClass">Тип контроллера</typeparam>
        /// <param name="baseView">Представление</param>
        /// <returns></returns>
        public TClass ResolveController<TClass>(IBaseView<TClass> baseView) where TClass : class, IBaseController
        {
            return _container.Get<TClass>();
        }

        #endregion

        #region private

        /// <summary>
        /// Логика
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterImp(IKernel container)
        {
            container.Bind<ApplicationParameters>().ToSelf().InSingletonScope();
            container.Bind<AppConfigFile>().ToSelf().InSingletonScope();

            RegisterControllers(container);
            RegisterValidators(container);
        }

        /// <summary>
        /// Регистрация контроллеров
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterControllers(IKernel container)
        {
            container.Bind<IMainController>().To<MainController>();
            container.Bind<IAutorizationController>().To<AutorizationController>();
            container.Bind<IAboutBoxProgramController>().To<AboutBoxProgramController>();
            container.Bind<IMessageBoxController>().To<MessageBoxController>();

            #region orders

            container.Bind<ICustomerLegalController>().To<CustomerLegalController>();
            container.Bind<ICustomerPrivateController>().To<CustomerPrivateController>();
            container.Bind<IOrderAddressController>().To<OrderAddressController>();
            container.Bind<IOrderCustomerController>().To<OrderCustomerController>();

            container.Bind<IOrderEditController>().To<OrderEditController>();
            container.Bind<IOrderListController>().To<OrderListController>();

            container.Bind<IOrderPartDeliveryController>().To<OrderPartDeliveryController>();
            container.Bind<IOrderPartPayController>().To<OrderPartPayController>();
            container.Bind<IOrderPartSpecificController>().To<OrderPartSpecificController>();

            #endregion

            #region settings

            container.Bind<ISettingsController>().To<SettingsController>();
            container.Bind<ISettingApplicationController>().To<SettingApplicationController>();

            #endregion
        }

        /// <summary>
        /// Регистрация валидаторов
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterValidators(IKernel container)
        {
            container.Bind<INomenclatureValidator>().To<NomenclatureValidator>();
            container.Bind<IFeatureValidator>().To<FeatureValidator>();
            container.Bind<IExpositionValidator>().To<ExpositionValidator>();
            container.Bind<IOrderValidator>().To<OrderValidator>();
            container.Bind<IOrderStatusValidator>().To<OrderStatusValidator>();
            container.Bind<IOrderSpecificationValidator>().To<OrderSpecificationValidator>();
            container.Bind<IUserValidator>().To<UserValidator>();
            container.Bind<ICustomerLegalValidator>().To<CustomerLegalValidator>();
            container.Bind<ICustomerPrivateValidator>().To<CustomerPrivateValidator>();
            container.Bind<IBasisActionValidator>().To<BasisActionValidator>();
            container.Bind<IDeliveryValidator>().To<DeliveryValidator>();
        }

        #endregion
    }
}
