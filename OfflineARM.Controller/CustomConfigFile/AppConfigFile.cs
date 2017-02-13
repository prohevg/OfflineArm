using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.XPath;
using OfflineARM.DAO.Helpers;

namespace OfflineARM.Controller.CustomConfigFile
{
    /// <summary>
    /// Конфигурационный файл клиента
    /// </summary>
    public sealed class AppConfigFile : BaseConfigFile
    {
        #region поля и свойства

        /// <summary>
        /// Наименование файла
        /// </summary>
        private const string FileName = "OfflineARM.config";

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public AppConfigFile(string path = "")
            : base(GetPath(path, FileName))
        {

        }

        #endregion

        #region методы

        /// <summary>
        /// Получить секцию из настроек 
        /// </summary>
        /// <param name="sectionName">Наименование секции</param>
        public T GetSection<T>(string sectionName) where T : ConfigurationSection, new()
        {
            var result = new T();

            var document = PrepareDocument();

            var elementConfiguration = document.XPathSelectElement(ConfigurationElementName);
            if (elementConfiguration == null)
            {
                return result;
            }

            var sectionElement = GetChildElementByName(elementConfiguration, sectionName);
            if (sectionElement == null)
            {
                return result;
            }

            foreach (var sectionChildElement in sectionElement.Elements())
            {
                FillElementFromXml(result, sectionChildElement);
            }

            return result;
        }

        /// <summary>
        /// Сохранить секцию в конфиге
        /// </summary>
        /// <param name="section">Секция</param>
        /// <param name="sectionName">Наименование секции</param>
        /// <returns></returns>
        public void Save<T>(T section, string sectionName) where T : ConfigurationSection
        {
            SaveInteranl(section, sectionName);
        }

        #endregion

        #region private

        /// <summary>
        /// Сохранить секцию в конфиге
        /// </summary>
        /// <param name="section">Секция</param>
        /// <param name="sectionName">Наименование секции</param>
        /// <returns></returns>
        private void SaveInteranl(ConfigurationSection section, string sectionName)
        {
            section.ThrowIfNull();

            var document = PrepareDocument();

            var elementConfiguration = AddElementToElementIfNotExist(document, ConfigurationElementName);
            var sectionElement = AddElementToElementIfNotExist(elementConfiguration, sectionName);

            FillXmlFromSection(section, sectionElement);

            Save(document);
        }

        /// <summary>
        /// Заполнить свойства секции значениями из хмл
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <param name="element">Элемент</param>
        /// <param name="properties">Список свойств объекта</param>
        private void FillElementFromXml(object obj, XElement element, PropertyInfo[] properties = null)
        {
            if (properties == null)
            {
                properties = obj.GetType().GetProperties();
            }

            var property = GetPropertyByName(properties, element.Name);
            if (property == null)
            {
                return;
            }

            var attributes = element.Attributes().ToList();
            if (!attributes.Any())
            {
                return;
            }

            //объект из свойства
            var instanceObjectProperty = property.GetValue(obj, null);

            //вложенные свойства свойства (другие элементы конфигурации и атрибуты)
            var propertiesForAttribute = property.PropertyType.GetProperties();
            foreach (var attribute in attributes)
            {
                var propertyForAttribute = GetPropertyByName(propertiesForAttribute, attribute.Name);
                if (propertyForAttribute == null)
                {
                    continue;
                }

                propertyForAttribute.SetValue(instanceObjectProperty, Parse(propertyForAttribute.PropertyType, attribute.Value), null);
            }

            foreach (var childElement in element.Elements())
            {
                var childProperties = instanceObjectProperty.GetType().GetProperties();
                FillElementFromXml(instanceObjectProperty, childElement, childProperties);
            }
        }

        /// <summary>
        /// Заполнить хмл значениями из объекта
        /// </summary>
        /// <param name="obj">Элемент конфигурации</param>
        /// <param name="element">Элемент Хмл</param>
        /// <param name="propertyInformations">Список свойств элемента конфигурации</param>
        private void FillXmlFromSection(ConfigurationElement obj, XElement element, PropertyInformationCollection propertyInformations = null)
        {
            obj.ThrowIfNull();

            if (propertyInformations == null)
            {
                propertyInformations = obj.ElementInformation.Properties;
            }

            var properties = obj.GetType().GetProperties();
            foreach (PropertyInformation propertyInformation in propertyInformations)
            {
                //поиск в свойствах объекта 
                var property = GetPropertyByName(properties, propertyInformation.Name);
                if (property == null)
                {
                    continue;
                }

                var value = property.GetValue(obj, null);
                if (value == null)
                {
                    continue;
                }

                //если это вложенный элемент
                var configElement = value as ConfigurationElement;
                if (configElement != null)
                {
                    var childElement = GetChildElementByName(element, propertyInformation.Name);
                    if (childElement != null)
                    {
                        childElement.Remove();
                    }

                    childElement = AddElementToElementIfNotExist(element, propertyInformation.Name);

                    FillXmlFromSection(configElement, childElement);
                }
                //если это атрибут
                else
                {
                    ModifyAttributeToElement(element, propertyInformation.Name, value);
                }
            }
        }

        /// <summary>
        /// Поиск свойства 
        /// </summary>
        /// <param name="properties">Список свойств объекта</param>
        /// <param name="name">Наименование свойства в хмл</param>
        /// <returns></returns>
        private PropertyInfo GetPropertyByName(PropertyInfo[] properties, XName name)
        {
            return properties.FirstOrDefault(pr => pr.Name.ToUpper() == name.LocalName.ToUpper());
        }

        /// <summary>
        /// Поиск дочернего элемента в элементе по имени
        /// </summary>
        /// <param name="element">Элемент</param>
        /// <param name="name">Наименование дочернего элемента</param>
        /// <returns></returns>
        private XElement GetChildElementByName(XElement element, string name)
        {
            name = GetElementName(name);
            return element.Element(name);
        }

        /// <summary>
        /// Имя элемента в хмл
        /// </summary>
        /// <param name="name">Наименование дочернего элемента</param>
        /// <returns></returns>
        private string GetElementName(string name)
        {
            return name.Length > 2 ? name[0].ToString().ToLower() + name.Substring(1) : name.ToLower();
        }

        /// <summary>
        /// Распарчить значение
        /// </summary>
        /// <param name="type">Тип значения</param>
        /// <param name="value">значение</param>
        /// <returns></returns>
        private object Parse(Type type, object value)
        {
            if (value == null)
            {
                return null;
            }
            else if (type == typeof(bool))
            {
                return bool.Parse(value.ToString());
            }
            else if (type == typeof(string))
            {
                return value.ToString();
            }
            else if (type == typeof(Int32))
            {
                return Int32.Parse(value.ToString());
            }
            else if (type == typeof(UInt16))
            {
                return UInt16.Parse(value.ToString());
            }


            throw new NotImplementedException();
        }

        #endregion
    }
}
