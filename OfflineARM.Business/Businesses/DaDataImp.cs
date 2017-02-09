using System;
using System.Collections.Generic;
using System.Linq;
using OfflineARM.Business.Businesses.Interfaces;
using OfflineARM.Business.DaData;
using OfflineARM.Business.Loggers;

namespace OfflineARM.Business.Businesses
{
    /// <summary>
    /// Реализация сервиса DaData
    /// </summary>
    public class DaDataImp : IDaDataImp
    {
        #region Конструктор

        /// <summary>
        /// Параметры приложения
        /// </summary>
        private readonly ApplicationParameters _parameters;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parameters">Параметры приложения</param>
        public DaDataImp(ApplicationParameters parameters)
        {
            _parameters = parameters;
        }

        #endregion

        /// <summary>
        /// Получить адрес из DaData
        /// </summary>
        /// <param name="template">шаблон адрес для DaData</param>
        /// <returns></returns>
        public List<string> GetAddress(string template)
        {
            try
            {
                var api = new DaDataClient(_parameters.DaDataToken, _parameters.DaDataUrlSuggestions);

                var response = api.QueryAddress(template);

                if (response.suggestions == null || response.suggestions.Count == 0)
                {
                    return new List<string>()
                    {
                        template
                    };
                }

                return response.suggestions.Select(suggestion => suggestion.value).ToList();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                Logger.Error(e.StackTrace);
            }

            return new List<string>() { template };
        }
    }
}
