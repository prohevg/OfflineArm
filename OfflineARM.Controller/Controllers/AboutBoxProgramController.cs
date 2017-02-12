using OfflineARM.Controller.Base;
using OfflineARM.Controller.ControllerInterfaces;
using OfflineARM.Controller.ViewInterfaces.Base;

namespace OfflineARM.Controller.Controllers
{
    /// <summary>
    /// Контроллер о программе
    /// </summary>
    public class AboutBoxProgramController : BaseController, IAboutBoxProgramController
    {
        #region IAboutBoxProgramController

        /// <summary>
        /// View для контролера
        /// </summary>
        /// <param name="view">Представление</param>
        public override void SetControllerView(IView view)
        {
            
        }

        /// <summary>
        /// override
        /// </summary>
        public override void LoadView()
        {
            
        }

        #endregion
    }
}
