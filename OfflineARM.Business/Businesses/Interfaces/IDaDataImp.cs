using System.Collections.Generic;

namespace OfflineARM.Business.Businesses.Interfaces
{
    /// <summary>
    /// Реализация сервиса DaData
    /// </summary>
    public interface IDaDataImp
    {
        /// <summary>
        /// Получить адрес из DaData
        /// </summary>
        /// <param name="template">шаблон адрес для DaData</param>
        /// <returns></returns>
        List<string> GetAddress(string template);
    }
}