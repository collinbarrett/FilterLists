using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;

namespace FilterLists.Data
{
    public static class FilterListsDbContextExtensions
    {
        private const string DataDirectory = "data";

        public static bool AllMigrationsApplied(this FilterListsDbContext dbContext)
        {
            var appliedMigrationIds = dbContext.GetService<IHistoryRepository>().GetAppliedMigrations()
                .Select(m => m.MigrationId);
            var allMigrationKeys = dbContext.GetService<IMigrationsAssembly>().Migrations.Select(m => m.Key);
            return !allMigrationKeys.Except(appliedMigrationIds).Any();
        }

        //TODO: consider handling deleted entities on seed
        //TODO: read entities from model and iterate over
        public static void SeedOrUpdate(this FilterListsDbContext dbContext)
        {
            dbContext.InsertOnDuplicateKeyUpdate<Language>();
            dbContext.InsertOnDuplicateKeyUpdate<License>();
            dbContext.InsertOnDuplicateKeyUpdate<Maintainer>();
            dbContext.InsertOnDuplicateKeyUpdate<Software>();
            dbContext.InsertOnDuplicateKeyUpdate<Syntax>();
            dbContext.InsertOnDuplicateKeyUpdate<FilterList>();
            dbContext.InsertOnDuplicateKeyUpdate<FilterListLanguage>();
            dbContext.InsertOnDuplicateKeyUpdate<FilterListMaintainer>();
            dbContext.InsertOnDuplicateKeyUpdate<Fork>();
            dbContext.InsertOnDuplicateKeyUpdate<Merge>();
            dbContext.InsertOnDuplicateKeyUpdate<SoftwareSyntax>();
        }

        //TODO: improve raw SQL against injection attacks
        private static void InsertOnDuplicateKeyUpdate<TEntityType>(this DbContext dbContext) where TEntityType : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntityType));
            var properties = GetPropertiesLessValueGeneratedTimestamps(entityType);
            var columns = string.Join(", ", properties.Select(x => x.Name));
            var values = CreateValues<TEntityType>(properties);
            var updates = CreateUpdates(properties);
            var rawSqlString = "INSERT INTO " + entityType.Relational().TableName + " (" + columns + ") VALUES " +
                               values + " ON DUPLICATE KEY UPDATE " + updates;
            dbContext.Database.ExecuteSqlCommand(rawSqlString);
            dbContext.SaveChanges();
        }

        private static List<IProperty> GetPropertiesLessValueGeneratedTimestamps(IEntityType entityType)
        {
            return entityType.GetProperties()
                .Where(x => x.ClrType != typeof(DateTime) || x.ValueGenerated == ValueGenerated.Never).ToList();
        }

        private static string CreateValues<TEntityType>(IReadOnlyCollection<IProperty> properties)
        {
            return GetSeedRows<TEntityType>().Select(row => CreateRowValues(properties, row)).Aggregate("",
                (current, rowValues) => current == "" ? rowValues : current + ", " + rowValues);
        }

        private static List<TEntityType> GetSeedRows<TEntityType>()
        {
#if DEBUG
            var path = Path.GetFullPath(Path.Combine(@"..\..\", DataDirectory));
#else
            var path = Path.GetFullPath(SeedDirectory);
#endif
            return JsonConvert.DeserializeObject<List<TEntityType>>(
                File.ReadAllText(path + Path.DirectorySeparatorChar + typeof(TEntityType).Name + ".json"));
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