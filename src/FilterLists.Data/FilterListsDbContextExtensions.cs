using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FilterLists.Data.Entities;
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
            SeedJunctions(context);
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
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(TEntity).Name + @".json"));
        }

        private static void InsertOnDuplicateKeyUpdate<TEntity>(DbContext dbContext) where TEntity : class
        {
            var tableName = GetTableName<TEntity>();
            var columnProperties = GetColumnPropertiesLessBaseEntityTimestamps<TEntity>();
            var columns = string.Join(", ", columnProperties.Select(x => x.Name));

            var rows = GetSeedRows<TEntity>();

            //TODO: create values query parameter string
            //format like:
            //('Helen', 24),
            //('Katrina', 21)
            var values = "";
            foreach (var row in rows)
            {
                var rowValues = "(";
                foreach (var property in columnProperties)
                {
                }

                rowValues += ")";
                values = values == "" ? rowValues : values + ", " + rowValues;
            }

            //TODO: create updates query parameter string
            //format like:
            //name = VALUES(name),
            //age = VALUES(age)
            var updates = "";

            dbContext.Set<TEntity>().FromSql(@"INSERT INTO {0} ({1}) VALUES {2} ON DUPLICATE KEY UPDATE {3}", tableName,
                columns, values, updates);
            dbContext.SaveChanges();
        }

        private static string GetTableName<TEntity>() where TEntity : class
        {
            //TODO: handle atypical plural forms (like 'syntaxes')
            return typeof(TEntity).Name.ToLower() + "s";
        }

        private static List<PropertyInfo> GetColumnPropertiesLessBaseEntityTimestamps<TEntity>() where TEntity : class
        {
            return typeof(TEntity).GetProperties().Where(x =>
                x.PropertyType.Namespace != "System.Collections.Generic" &&
                !new List<string> {"CreatedDateUtc", "ModifiedDateUtc"}.Contains(x.Name)).ToList();
        }
    }
}