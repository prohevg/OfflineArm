using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Linq;
using System.Text;
using FirebirdSql.Data.EntityFramework6;

namespace OfflineARM.DAO
{
    /// <summary>
    /// Генерация имен для внешних ключей и т.п.
    /// </summary>
    public class FirebirdSqlGenerator : FbMigrationSqlGenerator
    {
        /// <summary>
        /// Максимальное кол-во символов в наименовании
        /// </summary>
        private const int MaxNameLength = 30;

        #region override

        protected override IEnumerable<MigrationStatement> Generate(CreateIndexOperation operation)
        {
            operation.Name = GetIndexName(operation.Name, operation.Table);
            return base.Generate(operation);
        }

        protected override IEnumerable<MigrationStatement> Generate(DropIndexOperation operation)
        {
            operation.Name = GetIndexName(operation.Name, operation.Table);
            return base.Generate(operation);
        }

        protected override IEnumerable<MigrationStatement> Generate(AddForeignKeyOperation operation)
        {
            operation.Name = GetForeignKeyName(operation.PrincipalTable, operation.DependentTable, operation.DependentColumns.ToArray());
            return base.Generate(operation);
        }

        protected override IEnumerable<MigrationStatement> Generate(DropForeignKeyOperation operation)
        {
            operation.Name = GetForeignKeyName(operation.PrincipalTable, operation.DependentTable, operation.DependentColumns.ToArray());
            return base.Generate(operation);
        }

        #endregion


        #region private

        /// <summary>
        /// Создать наименование внешнего ключа
        /// </summary>
        /// <param name="indexName">Наименование индекса</param>
        /// <param name="tableName">Наименование таблицы</param>
        /// <returns></returns>
        private string GetIndexName(string indexName, string tableName)
        {
            var result = indexName.Replace("dbo.", "").Replace("_", "");
            var table = tableName.Replace("dbo.", "").Replace("_", "");
            return GetMaxString($"{result}{table}");
        }

        /// <summary>
        /// Создать наименование внешнего ключа
        /// </summary>
        /// <param name="primaryKeyTable">Главная таблица</param>
        /// <param name="foreignKeyTable">Таблица. на которую ссылаются</param>
        /// <param name="foreignTableFields">Столбцы</param>
        /// <returns></returns>
        private string GetForeignKeyName(string primaryKeyTable, string foreignKeyTable, params string[] foreignTableFields)
        {
            var maxLenghtTable = 5;
            var primaryName = GetShortName(primaryKeyTable, maxLenghtTable);
            var foreignKey = GetShortName(foreignKeyTable, maxLenghtTable);
            
            var fieldNames = new StringBuilder();
            if (foreignTableFields != null)
            {
                var maxLenghtField = (MaxNameLength - maxLenghtTable * 2 - 2)/ foreignTableFields.Length;
                foreach (var field in foreignTableFields)
                {
                    fieldNames.Append(GetShortName(field, maxLenghtField));
                }
            }

            return GetMaxString($"FK{primaryName}{foreignKey}{fieldNames}");
        }

        /// <summary>
        /// Получить короткое наименование 
        /// </summary>
        /// <param name="name">Наименование таблицы</param>
        /// <param name="maxSymbols">Макс кол-во символов в наименовании</param>
        /// <returns></returns>
        private string GetShortName(string name, int maxSymbols)
        {
            var result = name.Replace("dbo.", "").Replace("_", "");

            if (result.Length > maxSymbols)
            {
                result = result.Substring(0, maxSymbols);
            }

            return result;
        }

        /// <summary>
        /// Получить строку максимально допустимой длины
        /// </summary>
        /// <param name="name">Наименование, которое нужно обрезать</param>
        /// <returns></returns>
        private string GetMaxString(string name)
        {
            if (name.Length > MaxNameLength)
            {
                return name.Substring(0, MaxNameLength);
            }

            return name;
        }

        #endregion
    }
}
