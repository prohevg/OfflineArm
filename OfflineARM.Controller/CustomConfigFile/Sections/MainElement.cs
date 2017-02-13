using System.Configuration;

namespace OfflineARM.Controller.CustomConfigFile.Sections
{
    /// <summary>
    /// Главные настройки 
    /// </summary>
    public class MainElement : ConfigurationElement
    {
        #region Константы

        /// <summary>
        /// Наименование элемента Путь к документам
        /// </summary>
        private const string pathToDocuments = "pathToDocuments";

        #endregion

        #region Статические поля

        /// <summary>
        /// Путь к документам
        /// </summary>
        private static readonly ConfigurationProperty _pathToDocuments;

        #endregion

        #region Статический конструктор

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static MainElement()
        {
            _pathToDocuments = new ConfigurationProperty(pathToDocuments, typeof(string));
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Интервал, с которым периодически собираются статусы исполняющихся процессов
        /// </summary>
        [ConfigurationProperty(pathToDocuments, DefaultValue = "")]
        public string PathToDocuments
        {
            get
            {
                return (string)this[_pathToDocuments];
            }
            set
            {
                this[_pathToDocuments] = value;
            }
        }

        #endregion

        #region Переопределённые члены

        /// <summary>
        /// Сделаем возможность редактирования
        /// </summary>
        /// <returns></returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        #endregion
    }
}
