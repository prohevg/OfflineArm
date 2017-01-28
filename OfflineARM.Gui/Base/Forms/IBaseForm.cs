using System.Windows.Forms;

namespace OfflineARM.Gui.Base.Forms
{
    /// <summary>
    /// Базовый интерфейс окон
    /// </summary>
    public interface IBaseForm
    {
        /// <summary>
        /// Установить заголовок формы
        /// </summary>
        void SetCaptionForm();

        /// <summary>
        /// Открыть окно
        /// </summary>
        /// <returns></returns>
        void Show();

        /// <summary>
        /// Открыть как диалоговое окно
        /// </summary>
        /// <returns></returns>
        DialogResult ShowDialog();
    }
}
