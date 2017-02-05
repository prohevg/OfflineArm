using System;
using System.Windows.Forms;
using Ninject;
using OfflineARM.Gui.Forms.Orders;
using OfflineARM.Gui.Forms.Orders.Interfaces;
using OfflineARM.Gui.Interfaces.Windows;

namespace OfflineARM.Gui
{
    /// <summary>
    /// Контайнер форм
    /// </summary>
    public class IoCForm
    {
        #region поля и свойства

        /// <summary>
        /// Контейнер
        /// </summary>
        private IKernel _container;

        /// <summary>
        /// Instance
        /// </summary>
        public static readonly IoCForm Instance = new IoCForm();

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
        ///
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        public TClass Resolve<TClass>() where TClass : class
        {
            return _container.Get<TClass>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        public Form ResolveForm<TClass>() where TClass : class
        {
            var form = _container.Get<TClass>() as Form;
            if (form == null)
            {
                throw new ArgumentNullException(string.Format("{0} not exist", typeof(TClass).FullName));
            }
            return form;
        }

        #endregion

        #region private

        /// <summary>
        /// Формы
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterForm(IKernel container)
        {
            container.Bind<IMainForm>().To<MainForm>();
            container.Bind<ILoginForm>().To<LoginForm>();
            container.Bind<IAboutBoxProgram>().To<AboutBoxProgram>();

            container.Bind<IOrderListControl>().To<OrderListControl>();
            container.Bind<IOrderForm>().To<OrderForm>();

            container.Bind<ICustomerPrivateForm>().To<CustomerPrivateForm>();
            container.Bind<ICustomerLegalForm>().To<CustomerLegalForm>();
        }

        #endregion
    }
}
