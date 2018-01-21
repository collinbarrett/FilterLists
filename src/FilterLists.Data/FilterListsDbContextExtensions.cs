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
        private const string SeedDirectory = "Seed";

        public static bool AllMigrationsApplied(this FilterListsDbContext filterListsDbContext)
        {
            var appliedMigrationIds = filterListsDbContext.GetService<IHistoryRepository>().GetAppliedMigrations()
                .Select(m => m.MigrationId);
            var allMigrationKeys = filterListsDbContext.GetService<IMigrationsAssembly>().Migrations.Select(m => m.Key);
            return !allMigrationKeys.Except(appliedMigrationIds).Any();
        }

        public static void EnsureSeeded(this FilterListsDbContext filterListsDbContext)
        {
            SeedEntities(filterListsDbContext);
            //InsertOnDuplicateKeyUpdateEntities(filterListsDbContext);
            SeedJunctions(filterListsDbContext);
            //TODO: determine if InsertOnDuplicateKeyUpdate() will work for junctions
        }

        private static void SeedEntities(DbContext dbContext)
        {
            SeedIfEmpty<Language>(dbContext);
            SeedIfEmpty<License>(dbContext);
            SeedIfEmpty<Maintainer>(dbContext);
            SeedIfEmpty<Software>(dbContext);
            SeedIfEmpty<Syntax>(dbContext);
            SeedIfEmpty<FilterList>(dbContext);
        }

        private static void SeedJunctions(DbContext dbContext)
        {
            SeedIfEmpty<FilterListLanguage>(dbContext);
            SeedIfEmpty<FilterListMaintainer>(dbContext);
            SeedIfEmpty<Fork>(dbContext);
            SeedIfEmpty<Merge>(dbContext);
            SeedIfEmpty<SoftwareSyntax>(dbContext);
        }

        private static void SeedIfEmpty<TEntity>(DbContext dbContext) where TEntity : class
        {
            if (dbContext.Set<TEntity>().Any()) return;
            var rows = GetSeedRows<TEntity>();
            dbContext.AddRange(rows);
            dbContext.SaveChanges();
        }

        private static List<TEntityType> GetSeedRows<TEntityType>()
        {
            return JsonConvert.DeserializeObject<List<TEntityType>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(TEntityType).Name + ".json"));
        }

        private static void InsertOnDuplicateKeyUpdateEntities(DbContext dbContext)
        {
            InsertOnDuplicateKeyUpdate<Language>(dbContext);
            InsertOnDuplicateKeyUpdate<License>(dbContext);
            InsertOnDuplicateKeyUpdate<Maintainer>(dbContext);
            InsertOnDuplicateKeyUpdate<Software>(dbContext);
            InsertOnDuplicateKeyUpdate<Syntax>(dbContext);
            InsertOnDuplicateKeyUpdate<FilterList>(dbContext);
        }

        private static void InsertOnDuplicateKeyUpdate<TEntityType>(DbContext dbContext) where TEntityType : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntityType));
            var properties = GetPropertiesLessValueGeneratedTimestamps(entityType);
            var columns = string.Join(", ", properties.Select(x => x.Name));
            var values = CreateValues<TEntityType>(properties);
            var updates = CreateUpdates(properties);
            var rawSqlString = "INSERT INTO " + entityType.Relational().TableName + " (" + columns + ") VALUES " +
                               values + " ON DUPLICATE KEY UPDATE " + updates;
            dbContext.Set<TEntityType>().FromSql(rawSqlString);
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

        private static string CreateRowValues<TEntityType>(IEnumerable<IProperty> properties, TEntityType row)
        {
            return (from property in properties
                       let value = row.GetType().GetProperty(property.Name).GetValue(row)
                       select WrapStringValueInSingleQuotes(property, value)).Aggregate("",
                       (rowValues, value) => rowValues == "" ? "(" + value : rowValues + ", " + value) + ")";
        }

        private static object WrapStringValueInSingleQuotes(IProperty property, object value)
        {
            return property.ClrType == typeof(string) ? "'" + value + "'" : value;
        }

        private static string CreateUpdates(IEnumerable<IProperty> properties)
        {
            return (from property in properties
                where !property.IsPrimaryKey()
                select property.Name + " = VALUES(" + property.Name + ")").Aggregate("",
                (updates, columnUpdates) => updates == "" ? columnUpdates : updates + ", " + columnUpdates);
        }
    }
}