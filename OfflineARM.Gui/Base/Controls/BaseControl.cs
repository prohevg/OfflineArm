using System.Windows.Forms;

namespace OfflineARM.Gui.Base.Controls
{
    /// <summary>
    /// Базовый класс пользовательского контрола
    /// </summary>
    public abstract class BaseControl : UserControl, IBaseControl
    {
        #region IBaseControl

        /// <summary>
        /// Флаг наличия измененных данных
        /// </summary>
        public virtual bool HasChanges
        {
            get
            {
                return false;
            }
        }

        #endregion
    }
}
