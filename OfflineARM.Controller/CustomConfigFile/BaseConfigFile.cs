using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using OfflineARM.DAO.Helpers;

namespace OfflineARM.Controller.CustomConfigFile
{
    /// <summary>
    /// Абстрактный базовый класс пользовательской конфигурации
    /// </summary>
    public abstract class BaseConfigFile
    {
        #region поля и свойства

        #region constant

        /// <summary>
        /// элемент configuration
        /// </summary>
        protected const string ConfigurationElementName = "configuration";

        /// <summary>
        /// элемент ConfigurationElementName/AppSettingsElementName
        /// </summary>
        private const string AppSettingsElementName = "appSettings";

        /// <summary>
        /// элемент ConfigurationElementName/appSettings/AddElementName
        /// </summary>
        private const string AddElementName = "add";

        /// <summary>
        /// элемент ConfigurationElementName/appSettings/AddElementName[@key]
        /// </summary>
        private const string KeyAttributeName = "key";

        /// <summary>
        /// элемент ConfigurationElementName/appSettings/AddElementName[@value]
        /// </summary>
        private const string ValueAttributeName = "value";

        #endregion

        /// <summary>
        /// Путь к файлу конфигурации
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// Путь к файлу конфигурации
        /// </summary>
        public string ConfigPath
        {
            get
            {
                return _path;
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path">Путь к файлу конфигурации</param>
        protected BaseConfigFile(string path)
        {
            path.ThrowIfNull();
            this._path = path;
        }

        #endregion

        #region методы

        /// <summary>
        /// Получить значение настройки в секции AppSettings
        /// </summary>
        /// <param name="key">Ключ в AppSettingsElementName</param>
        public virtual string GetAppSetting(Enum key)
        {
            return GetAppSetting(key.ToString());
        }

        /// <summary>
        /// Получить значение настройки в секции AppSettings
        /// </summary>
        /// <param name="key">Ключ в AppSettings</param>
        /// <param name="value">Значение</param>
        public virtual void SetAppSetting(Enum key, object value)
        {
            SetAppSetting(key.ToString(), value);
        }

        /// <summary>
        /// Все настройки из секции AppSettings
        /// </summary>
        public virtual Dictionary<TEnum, string> GetAllAppSettings<TEnum>() where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("TEnum должен быть Enum");
            }

            var result = new Dictionary<TEnum, string>();

            var enumType = typeof(TEnum);
            var names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                var enumName = (TEnum)Enum.Parse(enumType, name);

                var enumValue = GetAppSetting(enumName.ToString());

                if (result.ContainsKey(enumName))
                {
                    result.Remove(enumName);
                }

                result.Add(enumName, enumValue);
            }

            return result;
        }

        #endregion

        #region protected методы

        /// <summary>
        /// Получить значение настройки в секции AppSettings
        /// </summary>
        /// <param name="key">Ключ в AppSettings</param>
        /// <returns></returns>
        protected string GetAppSetting(string key)
        {
            key.ThrowIfNull();

            var document = PrepareDocument();

            var xPathToKey = XPathKeyByValue(key);

            var addElement = document.XPathSelectElement(xPathToKey);

            if (addElement == null)
            {
                return string.Empty;
            }

            var valueAttribute = addElement.Attribute(ValueAttributeName);

            return valueAttribute != null ? valueAttribute.Value : null;
        }

        /// <summary>
        /// Сохранить значение настройки в секции AppSettings
        /// </summary>
        /// <param name="key">Ключ в AppSettings</param>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        protected void SetAppSetting(string key, object value)
        {
            key.ThrowIfNull();

            var document = PrepareDocument();

            var xPathToKey = XPathKeyByValue(key);
            var elementAdd = document.XPathSelectElement(xPathToKey);

            //существует в xml
            if (elementAdd != null)
            {
                ModifyAttributeToElement(elementAdd, ValueAttributeName, value);
            }
            else
            {
                var elementConfiguration = AddElementToElementIfNotExist(document, ConfigurationElementName);
                var elementAppSettings = AddElementToElementIfNotExist(elementConfiguration, AppSettingsElementName);

                elementAdd = new XElement(AddElementName);
                elementAppSettings.Add(elementAdd);

                AddAttributeToElementIfNotExist(elementAdd, KeyAttributeName, key);
                AddAttributeToElementIfNotExist(elementAdd, ValueAttributeName, value);
            }

            CreateDirectoryIfNotExist(_path);

            document.Save(_path);
        }

        /// <summary>
        /// Метод получения пути к конфигурационному файлу
        /// </summary>
        /// <param name="path">Путь к конфигурационному файлу</param>
        /// <param name="fileName">Наименование файла</param>
        /// <returns></returns>
        protected static string GetPath(string path = "", string fileName = "")
        {
            if (!string.IsNullOrEmpty(path))
            {
                return path;
            }

            var currentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            return Path.Combine(currentDirectory, "OfflineARM\\OfflineARM", fileName);
        }

        /// <summary>
        /// Открыть документ. Если не возможно загрузить, создать его
        /// </summary>
        /// <returns></returns>
        protected XDocument PrepareDocument()
        {
            XDocument document;
            try
            {
                document = File.Exists(_path) ? XDocument.Load(_path) : new XDocument();
            }
            catch
            {
                document = new XDocument();
            }

            return document;
        }

        /// <summary>
        /// Сохранить документ
        /// </summary>
        /// <param name="document"></param>
        protected void Save(XDocument document)
        {
            CreateDirectoryIfNotExist(_path);

            document.Save(_path);
        }

        /// <summary>
        /// Получить XPath к атрибуту configuration/appSettings/add[@key=""] 
        /// </summary>
        /// <param name="value">Значение атрибута</param>
        /// <returns></returns>
        private string XPathKeyByValue(object value)
        {
            return XPathAppSettingsAttributeByValue(KeyAttributeName, value);
        }

        /// <summary>
        /// Получить XPath к атрибуту по значению
        /// </summary>
        /// <param name="attrName">Наименование атрибута</param>
        /// <param name="value">Значение атрибута</param>
        /// <returns></returns>
        private string XPathAppSettingsAttributeByValue(string attrName, object value)
        {
            return string.Format("{0}/{1}/{2}[@{3}='{4}']", ConfigurationElementName, AppSettingsElementName, AddElementName, attrName, value);
        }

        /// <summary>
        /// Создать директорию, если она не существует
        /// </summary>
        /// <param name="path"></param>
        private void CreateDirectoryIfNotExist(string path)
        {
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                var dirSecurity = new DirectorySecurity();
                dirSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                                                        FileSystemRights.FullControl, InheritanceFlags.ContainerInherit |
                                                        InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                Directory.CreateDirectory(directory, dirSecurity);
            }
        }

        #endregion

        #region XDocument

        /// <summary>
        /// Добавить элемент в документ, если он не существует
        /// </summary>
        /// <param name="document">Документ</param>
        /// <param name="childElementName">Наименование дочернего элемента</param>
        protected XElement AddElementToElementIfNotExist(XDocument document, string childElementName)
        {
            document.ThrowIfNull();
            childElementName.ThrowIfNull();

            var childElement = document.Element(childElementName);
            if (childElement == null)
            {
                childElement = new XElement(childElementName);
                document.Add(childElement);
            }

            return childElement;
        }

        /// <summary>
        /// Добавить элемент в элемент, если он не существует
        /// </summary>
        /// <param name="element">Родительский элемент</param>
        /// <param name="childElementName">Наименование дочернего элемента</param>
        protected XElement AddElementToElementIfNotExist(XElement element, string childElementName)
        {
            element.ThrowIfNull();
            childElementName.ThrowIfNull();

            var childElement = element.Element(childElementName);
            if (childElement == null)
            {
                childElement = new XElement(childElementName);
                element.Add(childElement);
            }

            return childElement;
        }

        /// <summary>
        /// Добавить атрибут в элемент, если он не существует
        /// </summary>
        /// <param name="element">Родительский элемент</param>
        /// <param name="attributeName">Наименование атрибута элемента</param>
        /// <param name="value">Значение атрибута</param>
        protected XAttribute AddAttributeToElementIfNotExist(XElement element, string attributeName, object value)
        {
            element.ThrowIfNull();
            attributeName.ThrowIfNull();

            var attribute = element.Attribute(attributeName);
            if (attribute == null)
            {
                attribute = new XAttribute(attributeName, value);
                element.Add(attribute);
            }

            return attribute;
        }

        /// <summary>
        /// Изменить значение атрибута в элементе. Создать он не существует
        /// </summary>
        /// <param name="element">Родительский элемент</param>
        /// <param name="attributeName">Наименование атрибута элемента</param>
        /// <param name="value">Значение атрибута</param>
        protected XAttribute ModifyAttributeToElement(XElement element, string attributeName, object value)
        {
            var attribute = AddAttributeToElementIfNotExist(element, attributeName, value);

            attribute.Value = value != null ? value.ToString() : "";

            return attribute;
        }

        #endregion
    }
}
