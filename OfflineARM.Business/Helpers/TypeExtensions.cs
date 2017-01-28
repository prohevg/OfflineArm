using System;
using System.Linq;

namespace OfflineARM.Business.Helpers
{
    /// <summary>
    /// Расширения класса System.Type
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Возвращает флаг, указывающий, реализует ли заданный тип указанный интерфейс
        /// </summary>
        /// <param name="typeToTest">Тип</param>
        /// <param name="interfaceType">Тип интерфейса</param>
        /// <returns>true, если тип реализует указанный интерфейс, иначе false</returns>
        public static bool ImplementsInterface(this Type typeToTest, Type interfaceType)
        {
            return typeToTest.GetInterfaces().Any(x => (x.IsGenericType ?
                x.GetGenericTypeDefinition() == interfaceType : x == interfaceType));
        }

        /// <summary>
        /// Возвращает флаг, указывающий, является ли тип наследником обобщенного типа
        /// </summary>
        /// <param name="typeToTest">Тип</param>
        /// <param name="genericType">Обобщённый тип</param>
        /// <returns>true, если тип является наследником обобщенного типа, иначе false</returns>
        public static bool IsDerivedFromGenericType(this Type typeToTest, Type genericType)
        {
            if (typeToTest == typeof(object))
            {
                return false;
            }

            Type baseType = typeToTest.BaseType;
            baseType = (baseType.IsGenericType ? baseType.GetGenericTypeDefinition() : baseType);
            if (baseType == genericType)
            {
                return true;
            }

            return baseType.IsDerivedFromGenericType(genericType);
        }
    }
}
