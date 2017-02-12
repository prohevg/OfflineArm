namespace OfflineARM.View.Base.Controls
{
    /// <summary>
    /// Контрол, который является частью формы или контрола
    /// </summary>
    public interface IBasePartControlView : IBaseControlView
    {
        /// <summary>
        /// Инициализация контрола
        /// </summary>
        void Initialization();
    }
}
