using Ninject;
using OfflineARM.Business.Autorizations;

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

        #region public

        /// <summary>
        /// Логика
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterImp(IKernel container)
        {
            container.Bind<IAutorizationImp>().To<AutorizationImp>();
        }

        #endregion
    }
}
