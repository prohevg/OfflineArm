using Ninject;
using OfflineARM.Business.Autorizations;
using OfflineARM.Business.Businesses;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.Dictionaries;
using OfflineARM.Business.Dictionaries.Interfaces;
using OfflineARM.Business.Validators.Businesses;
using OfflineARM.Business.Validators.Businesses.Interfaces;
using OfflineARM.Business.Validators.Dictionaries;
using OfflineARM.Business.Validators.Dictionaries.Interfaces;

namespace OfflineARM.Business
{
    /// <summary>
    /// Регистрация компонент логики
    /// </summary>
    public class IoCBusiness
    {
        #region поля и свойства

        /// <summary>
        /// Контейнер
        /// </summary>
        private IKernel _container;

        /// <summary>
        /// Instance
        /// </summary>
        public static readonly IoCBusiness Instance = new IoCBusiness();

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

        #endregion

        #region private

        /// <summary>
        /// Логика
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterImp(IKernel container)
        {
            container.Bind<ApplicationParameters>().ToSelf().InSingletonScope();

            container.Bind<IAutorizationImp>().To<AutorizationImp>();

            container.Bind<INomenclatureImp>().To<NomenclatureImp>();
            container.Bind<INomenclatureValidator>().To<NomenclatureValidator>();

            container.Bind<IFeatureImp>().To<FeatureImp>();
            container.Bind<IFeatureValidator>().To<FeatureValidator>();

            container.Bind<IExpositionImp>().To<ExpositionImp>();
            container.Bind<IExpositionValidator>().To<ExpositionValidator>();

            container.Bind<IOrderImp>().To<OrderImp>();
            container.Bind<IOrderValidator>().To<OrderValidator>();

            container.Bind<IOrderStatusImp>().To<OrderStatusImp>();
            container.Bind<IOrderStatusValidator>().To<OrderStatusValidator>();

            container.Bind<IOrderSpecificationImp>().To<OrderSpecificationImp>();
            container.Bind<IOrderSpecificationValidator>().To<OrderSpecificationValidator>();

            container.Bind<IUserImp>().To<UserImp>();
            container.Bind<IUserValidator>().To<UserValidator>();

            container.Bind<ICustomerLegalImp>().To<CustomerLegalImp>();
            container.Bind<ICustomerLegalValidator>().To<CustomerLegalValidator>();

            container.Bind<ICustomerPrivateImp>().To<CustomerPrivateImp>();
            container.Bind<ICustomerPrivateValidator>().To<CustomerPrivateValidator>();

            container.Bind<IBasisActionImp>().To<BasisActionImp>();
            container.Bind<IBasisActionValidator>().To<BasisActionValidator>();

            container.Bind<IDeliveryImp>().To<DeliveryImp>();
            container.Bind<IDeliveryValidator>().To<DeliveryValidator>();

            container.Bind<IDaDataImp>().To<DaDataImp>();
        }

        #endregion
    }
}
