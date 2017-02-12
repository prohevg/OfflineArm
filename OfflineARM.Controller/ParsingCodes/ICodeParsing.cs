namespace OfflineARM.Controller.ParsingCodes
{
    /// <summary>
    /// Парсинг штрих кода
    /// </summary>
    public interface ICodeParsing<T>
        where T : ParseResult
    {
        /// <summary>
        /// Возможен парсинг строки штрихкода (соответствует маске)
        /// </summary>
        bool CanParse();

        /// <summary>
        /// Парсинг строки штрихкода
        /// </summary>
        T Parse();
    }
}