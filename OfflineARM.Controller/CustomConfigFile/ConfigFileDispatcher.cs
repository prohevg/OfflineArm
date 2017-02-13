namespace OfflineARM.Controller.CustomConfigFile
{
    /// <summary>
    /// Конфигурационный файл для процесса
    /// </summary>
    public class ConfigFileDispatcher
    {
        #region поля и свойства

        /// <summary>
        /// Экземпляр
        /// </summary>
        public static readonly ConfigFileDispatcher Instance = new ConfigFileDispatcher();

        /// <summary>
        /// Конфигурационный файл
        /// </summary>
        private BaseConfigFile _configFile;

        /// <summary>
        /// Конфигурационный файл
        /// </summary>
        public BaseConfigFile ConfigFile
        {
            get
            {
                return _configFile;
            }
            set
            {
                if (_configFile == null)
                {
                    _configFile = value;
                }
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        private ConfigFileDispatcher()
        {

        }

        #endregion

        #region методы

        /// <summary>
        /// Конфигурационный файл
        /// </summary>
        public T GetConfigFile<T>() where T : BaseConfigFile
        {
            return _configFile as T;
        }

        #endregion
    }
}
