namespace OfflineARM.Controller.ViewInterfaces
{
    /// <summary>
    /// Кнопка в меню
    /// </summary>
    public interface IBarItem
    {
        /// <summary>
        /// Данные кнопки
        /// </summary>
        object Tag { get; set; }
    }
}
