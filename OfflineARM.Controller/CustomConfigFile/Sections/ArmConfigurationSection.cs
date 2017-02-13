using System.Configuration;

namespace OfflineARM.Controller.CustomConfigFile.Sections
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    public class ArmConfigurationSection : ConfigurationSection
    {
        #region Константы

        /// <summary>
        /// Наименование секции
        /// </summary>
        public const string SectionName = "armConfigurations";

        /// <summary>
        /// Наименование элемента секции Верхняя панель
        /// </summary>
        public const string MainName = "main";

        #endregion

        #region Статические поля

        /// <summary>
        /// Путь к документам
        /// </summary>
        private static readonly ConfigurationProperty _main;

        /// <summary>
        /// Коллекция свойств
        /// </summary>
        private static readonly ConfigurationPropertyCollection _properties;

        #endregion

        #region Статический конструктор

		/// <summary>
		/// Статический конструктор
		/// </summary>
        static ArmConfigurationSection()
		{
            _main = new ConfigurationProperty(MainName, typeof(MainElement), null, ConfigurationPropertyOptions.None);

            _properties = new ConfigurationPropertyCollection
            {
                _main
            };
		}

		#endregion

        #region Переопределённые члены

        /// <summary>
        /// Свойства
        /// </summary>
        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                return _properties;
            }
        }

        /// <summary>
        /// Сделаем возможность редактирования
        /// </summary>
        /// <returns></returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        #endregion
        
        #region Свойства

        /// <summary>
        /// Настройки компонента Main
        /// </summary>
        [ConfigurationProperty(MainName)]
        public MainElement Main
        {
            get
            {
                return (MainElement)base[_main];
            }
        }

        #endregion

    }
}
