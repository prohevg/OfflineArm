using DevExpress.XtraEditors;

namespace OfflineARM.Gui.Controls
{
    /// <summary>
    /// Текстовй контро для телефона
    /// </summary>
    public class PhoneControl : TextEdit
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public PhoneControl()
        {
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Properties.Mask.EditMask = @"(\(\d{1,5}\))?\d{1,3}-\d\d-\d\d";
            this.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
        }
    }
}
