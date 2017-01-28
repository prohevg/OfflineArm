using System.Windows.Forms;

namespace OfflineARM.Gui.Base.Forms
{
    /// <summary>
    /// Форма без ресайзинга
    /// </summary>
    public class BaseFormDisableResize : BaseForm
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseFormDisableResize()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
