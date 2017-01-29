using System.Drawing;
using System.Windows.Forms;

namespace OfflineARM.Gui.Base.Forms
{
    /// <summary>
    /// Базовый интерфейс окон
    /// </summary>
    public interface IBaseForm
    {
        /// <summary>
        /// Установить минимальный размер формы
        /// </summary>
        void SetMinimumSize(Size? size = null);

        /// <summary>
        /// Открыть окно
        /// </summary>
        /// <returns></returns>
        void Show();

        /// <summary>
        /// Открыть как диалоговое окно
        /// </summary>
        /// <returns></returns>
        DialogResult ShowDialog(IBaseForm parent = null);
    }
}
