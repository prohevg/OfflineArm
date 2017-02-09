using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineARM.Business
{
    /// <summary>
    /// Параметры приложений
    /// </summary>
    public class ApplicationParameters
    {
        /// <summary>
        /// Token сервиса DaData
        /// </summary>
        public string DaDataUrlSuggestions
        {
            get
            {
                return "https://suggestions.dadata.ru/suggestions/api/4_1/rs";
            }
        }

        /// <summary>
        /// Token сервиса DaData
        /// </summary>
        public string DaDataToken
        {
            get
            {
                return "c38d5b46127f5c4a87aa6cb7adfe0a538efd7266";
            }
        }

        /// <summary>
        /// Секретный ключ сервиса DaData
        /// </summary>
        public string DaDataKey
        {
            get
            {
                return "6daee90893e9d5196f2881c7973fb2d3e5bd1e55";
            }
        }
    }
}
