using OfflineARM.Controller.CustomConfigFile;
using OfflineARM.Controller.CustomConfigFile.Sections;

namespace OfflineARM.Controller
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

        /// <summary>
        /// Путь к документам
        /// </summary>
        public string PathToDocuments
        {
            get
            {
                var armConfig = IoCControllers.Instance.Get<AppConfigFile>();
                var section = armConfig.GetSection<ArmConfigurationSection>(ArmConfigurationSection.SectionName);
                return section.Main.PathToDocuments;
            }
        }
    }
}
