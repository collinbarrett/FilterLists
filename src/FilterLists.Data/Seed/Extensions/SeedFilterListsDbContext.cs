using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;

namespace FilterLists.Data.Seed.Extensions
{
    public static class SeedFilterListsDbContext
    {
        //TODO: consider handling deleted entities on seed
        //TODO: read entities from model and iterate over
        public static void SeedOrUpdate(this FilterListsDbContext dbContext, string dataPath)
        {
            dbContext.InsertOnDuplicateKeyUpdate<Language>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<License>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<Maintainer>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<Software>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<Syntax>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<FilterList>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<FilterListLanguage>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<FilterListMaintainer>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<Fork>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<Merge>(dataPath);
            dbContext.InsertOnDuplicateKeyUpdate<SoftwareSyntax>(dataPath);
        }

        //TODO: improve raw SQL against injection attacks
        private static void InsertOnDuplicateKeyUpdate<TEntityType>(this DbContext dbContext, string dataPath)
            where TEntityType : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntityType));
            var properties = GetPropertiesLessValueGeneratedTimestamps(entityType);
            var values = CreateValues<TEntityType>(properties, dataPath);
            if (values == "") return;
            var columns = string.Join(", ", properties.Select(x => x.Name));
            var updates = CreateUpdates(properties);
            var rawSqlString = "INSERT INTO " + entityType.Relational().TableName + " (" + columns + ") VALUES " +
                               values + " ON DUPLICATE KEY UPDATE " + updates;
            dbContext.Database.ExecuteSqlCommand(rawSqlString);
            dbContext.SaveChanges();
        }

        private static List<IProperty> GetPropertiesLessValueGeneratedTimestamps(IEntityType entityType)
        {
            return entityType.GetProperties().Where(x => x.Name != "CreatedDateUtc" && x.Name != "ModifiedDateUtc")
                .ToList();
        }

        private static string CreateValues<TEntityType>(IReadOnlyCollection<IProperty> properties, string dataPath)
        {
            return GetSeedRows<TEntityType>(dataPath).Select(row => CreateRowValues(properties, row)).Aggregate("",
                (current, rowValues) => current == "" ? rowValues : current + ", " + rowValues);
        }

        private static List<TEntityType> GetSeedRows<TEntityType>(string dataPath)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TEntityType>>(
                    File.ReadAllText(dataPath + Path.DirectorySeparatorChar + typeof(TEntityType).Name + ".json"));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return new List<TEntityType>();
            }
        }

        private static string CreateRowValues<TEntityType>(IEnumerable<IProperty> properties, TEntityType row)
        {
            return (from property in properties
                       let value = row.GetType().GetProperty(property.Name).GetValue(row)
                       select FormatDataForMySql(property, value)).Aggregate("",
                       (rowValues, value) => rowValues == "" ? "(" + value : rowValues + ", " + value) + ")";
        }

        //TODO: use .NET, EF, or other library rather than maintaining this
        private static object FormatDataForMySql(IProperty property, object value)
        {
            if (value == null) return "NULL";
            if (property.ClrType == typeof(string))
                return "'" + value.ToString().Replace("'", "''") + "'";
            if (property.ClrType == typeof(bool))
                return Convert.ToInt32(value);
            if (property.ClrType == typeof(DateTime?))
                return "'" + ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss") + "'";
            return value;
        }

        private static string CreateUpdates(IReadOnlyCollection<IProperty> properties)
        {
            var update =
            (from property in properties
                where !property.IsPrimaryKey()
                select property.Name + " = VALUES(" + property.Name + ")").Aggregate("",
                (updates, columnUpdates) => updates == "" ? columnUpdates : updates + ", " + columnUpdates);
            if (update == "") update = GetUpdateUnchangedColumnHack(properties);
            return update;
        }

        //TODO: eliminate wasted IO updating unchanged column (https://stackoverflow.com/a/4596409/2343739)
        private static string GetUpdateUnchangedColumnHack(IEnumerable<IProperty> properties)
        {
            var firstId = properties.First(x => x.IsPrimaryKey()).Name;
            return firstId + " = VALUES(" + firstId + ")";
        }
    }
}