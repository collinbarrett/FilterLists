using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FilterLists.Data.Entities;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;

namespace FilterLists.Data
{
    public static class FilterListsDbContextExtensions
    {
        private const string SeedDirectory = "Seed";

        public static bool AllMigrationsApplied(this FilterListsDbContext context)
        {
            var appliedMigrationIds = context.GetService<IHistoryRepository>().GetAppliedMigrations()
                .Select(m => m.MigrationId);
            var allMigrationKeys = context.GetService<IMigrationsAssembly>().Migrations.Select(m => m.Key);
            return !allMigrationKeys.Except(appliedMigrationIds).Any();
        }

        public static void EnsureSeeded(this FilterListsDbContext context)
        {
            SeedEntities(context);
            //InsertOnDuplicateKeyUpdateEntities(context);
            SeedJunctions(context);
            //TODO: determine if InsertOnDuplicateKeyUpdateEntities() will work for junctions
        }

        private static void SeedEntities(DbContext context)
        {
            Seed<Language>(context);
            Seed<License>(context);
            Seed<Maintainer>(context);
            Seed<Software>(context);
            Seed<Syntax>(context);
            Seed<FilterList>(context);
        }

        private static void SeedJunctions(DbContext context)
        {
            Seed<FilterListLanguage>(context);
            Seed<FilterListMaintainer>(context);
            Seed<Fork>(context);
            Seed<Merge>(context);
            Seed<SoftwareSyntax>(context);
        }

        private static void Seed<TEntity>(DbContext dbContext) where TEntity : class
        {
            if (dbContext.Set<TEntity>().Any()) return;
            var rows = GetSeedRows<TEntity>();
            dbContext.AddRange(rows);
            dbContext.SaveChanges();
        }

        private static List<TEntity> GetSeedRows<TEntity>()
        {
            return JsonConvert.DeserializeObject<List<TEntity>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(TEntity).Name + ".json"));
        }

        private static void InsertOnDuplicateKeyUpdateEntities(DbContext context)
        {
            InsertOnDuplicateKeyUpdate<Language>(context);
            InsertOnDuplicateKeyUpdate<License>(context);
            InsertOnDuplicateKeyUpdate<Maintainer>(context);
            InsertOnDuplicateKeyUpdate<Software>(context);
            InsertOnDuplicateKeyUpdate<Syntax>(context);
            InsertOnDuplicateKeyUpdate<FilterList>(context);
        }

        private static void InsertOnDuplicateKeyUpdate<TEntity>(DbContext dbContext) where TEntity : class
        {
            var columnProperties = GetColumnPropertiesLessBaseEntityTimestamps<TEntity>();
            var tableName = GetTableName<TEntity>();
            var columns = string.Join(", ", columnProperties.Select(x => x.Name));
            var values = CreateValues<TEntity>(columnProperties);
            var updates = CreateUpdates(columnProperties);
            var rawSqlString = "INSERT INTO " + tableName + " (" + columns + ") VALUES " + values +
                               " ON DUPLICATE KEY UPDATE " + updates;
            dbContext.Set<TEntity>().FromSql(rawSqlString);
            dbContext.SaveChanges();
        }

        private static string GetTableName<TEntity>()
        {
            return typeof(TEntity).Name.Pluralize().ToLower();
        }

        private static List<PropertyInfo> GetColumnPropertiesLessBaseEntityTimestamps<TEntity>()
        {
            return typeof(TEntity).GetProperties().Where(x =>
                x.PropertyType.Namespace != "System.Collections.Generic" &&
                !new List<string> {"CreatedDateUtc", "ModifiedDateUtc"}.Contains(x.Name)).ToList();
        }

        private static string CreateValues<TEntity>(IReadOnlyCollection<PropertyInfo> columnProperties)
        {
            return GetSeedRows<TEntity>().Select(row => CreateRowValues(columnProperties, row)).Aggregate("",
                (current, rowValues) => current == "" ? rowValues : current + ", " + rowValues);
        }

        private static string CreateRowValues<TEntity>(IEnumerable<PropertyInfo> columnProperties, TEntity row)
        {
            return (from property in columnProperties
                       let value = row.GetType().GetProperty(property.Name).GetValue(row)
                       select WrapStringPropertyValueInSingleQuotes(property, value)).Aggregate("",
                       (current, value) => current == "" ? "(" + value : current + ", " + value) + ")";
        }

        private static object WrapStringPropertyValueInSingleQuotes(PropertyInfo property, object value)
        {
            if (property.PropertyType == typeof(string))
                value = "'" + value + "'";
            return value;
        }

        private static string CreateUpdates(IEnumerable<PropertyInfo> columnProperties)
        {
            //TODO: filter keys out
            return columnProperties.Select(property => property.Name).Aggregate("", (current, column) => current == ""
                ? column + " = VALUES(" + column + ")"
                : current + ", " + column + " = VALUES(" + column + ")");
        }
    }
}