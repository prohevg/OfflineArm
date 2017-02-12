using OfflineARM.Controller.Base;

namespace OfflineARM.Controller.ControllerInterfaces
{
    /// <summary>
    /// Контролер формы авторизации
    /// </summary>
    public interface IAutorizationController : IBaseController
    {
        /// <summary>
        /// true, если авторизовался
        /// </summary>
        /// <returns></returns>
        bool IsSuccessAutorization();
    }
}
