using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Controllers
{
    /// <summary>
    /// Контроллер формы авторизации
    /// </summary>
    public class AutorizationController : BaseController, IAutorizationController
    {
        #region поля и свойства

        /// <summary>
        /// View авторизации
        /// </summary>
        private IAutorizationView _autorizationView;

        #endregion

        #region IAutorizationController

        /// <summary>
        /// true, если авторизовался
        /// </summary>
        /// <returns></returns>
        public bool IsSuccessAutorization()
        {
            //using (var unit = new UnitOfWork())
            //{
            //    var login = _autorizationView.Login;
            //    var password = _autorizationView.Password;
            //    return unit.DictionaryRepositories.UserRepository.IsSuccessAutorization();
            //}
            return (_autorizationView.Login == "admin" && _autorizationView.Password == "admin")
                || (_autorizationView.Login == "test" && _autorizationView.Password == "test");
        }

        #endregion

        #region override

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            _autorizationView = (IAutorizationView) view;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public override void LoadView()
        {
#if DEBUG
            _autorizationView.Login = "admin";
            _autorizationView.Password = "admin";
#endif
        }

        #endregion
    }
}
