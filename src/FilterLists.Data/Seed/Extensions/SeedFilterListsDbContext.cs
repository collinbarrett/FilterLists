using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;

namespace FilterLists.Data.Seed.Extensions
{
    public static class SeedFilterListsDbContext
    {
        public static async Task SeedOrUpdateAsync(FilterListsDbContext dbContext, string dataPath)
        {
            await SeedOrUpdate<Language>(dbContext, dataPath);
            await SeedOrUpdate<License>(dbContext, dataPath);
            await SeedOrUpdate<Maintainer>(dbContext, dataPath);
            await SeedOrUpdate<Software>(dbContext, dataPath);
            await SeedOrUpdate<Syntax>(dbContext, dataPath);
            await SeedOrUpdate<Tag>(dbContext, dataPath);
            await SeedOrUpdate<FilterList>(dbContext, dataPath);
            await SetDefaultLicenseIdAsync(dbContext);
            await SeedOrUpdate<FilterListLanguage>(dbContext, dataPath);
            await SeedOrUpdate<FilterListMaintainer>(dbContext, dataPath);
            await SeedOrUpdate<FilterListTag>(dbContext, dataPath);
            await SeedOrUpdate<Dependent>(dbContext, dataPath);
            await SeedOrUpdate<Fork>(dbContext, dataPath);
            await SeedOrUpdate<Merge>(dbContext, dataPath);
            await SeedOrUpdate<SoftwareSyntax>(dbContext, dataPath);
        }

        private static async Task SeedOrUpdate<TEntity>(DbContext dbContext, string dataPath)
            where TEntity : class, IBaseEntity
        {
            var seed = GetSeed<TEntity>(dataPath);
            await ApplyRemovals(dbContext, seed);
            await InsertOnDuplicateKeyUpdate(dbContext, seed);
        }

        private static List<TEntity> GetSeed<TEntity>(string dataPath) where TEntity : IBaseEntity
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TEntity>>(
                    File.ReadAllText(Path.Combine(dataPath, typeof(TEntity).Name + ".json")));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return new List<TEntity>();
            }
        }

        private static async Task ApplyRemovals<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : class
        {
            var removedEntities = GetRemovedEntities(dbContext, seed);
            dbContext.RemoveRange(removedEntities);
            await dbContext.SaveChangesAsync();
        }

        //https://stackoverflow.com/a/52264468/2343739
        private static IEnumerable<TEntity> GetRemovedEntities<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntity));
            var dbEntity = Expression.Parameter(entityType.ClrType, "e");
            var matchesAnyPk = GetMatchesAnyPk(seed, entityType, dbEntity);
            var notInSeed = Expression.Lambda<Func<TEntity, bool>>(Expression.Not(matchesAnyPk), dbEntity);
            return dbContext.Set<TEntity>().Where(notInSeed);
        }

        private static Expression GetMatchesAnyPk<TEntity>(IEnumerable<TEntity> seed, IEntityType entityType,
            Expression dbEntity) where TEntity : class =>
            seed.Select(e => entityType.FindPrimaryKey()
                                       .Properties.Select(p =>
                                           Expression.Equal(Expression.Property(dbEntity, p.PropertyInfo),
                                               Expression.Property(Expression.Constant(e), p.PropertyInfo)))
                                       .Aggregate(Expression.AndAlso))
                .Aggregate(null,
                    (Func<Expression, BinaryExpression, Expression>)((current, match) =>
                        current != null ? Expression.OrElse(current, match) : match));

        private static async Task InsertOnDuplicateKeyUpdate<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : IBaseEntity
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntity));
            var properties = GetPropertiesLessValueGeneratedTimestamps(entityType);
            var values = CreateValues(seed, properties);
            if (values == "")
                return;
            var columns = string.Join(", ", properties.Select(x => x.Name));
            var updates = CreateUpdates(properties);
            var sql = "INSERT INTO " + entityType.Relational().TableName + " (" + columns + ") VALUES " + values +
                      " ON DUPLICATE KEY UPDATE " + updates;
            await dbContext.Database.ExecuteSqlCommandAsync(sql);
        }

        private static List<IProperty> GetPropertiesLessValueGeneratedTimestamps(IEntityType entityType) =>
            entityType.GetProperties()
                      .Where(x =>
                          !new List<string> {"CreatedDateUtc", "ModifiedDateUtc", "DiscontinuedDate"}.Contains(x.Name))
                      .ToList();

        private static string CreateValues<TEntity>(IEnumerable<TEntity> seed,
            IReadOnlyCollection<IProperty> properties) where TEntity : IBaseEntity =>
            seed.Select(row => CreateRowValues(properties, row))
                .Aggregate("", (current, rowValues) => current == "" ? rowValues : current + ", " + rowValues);

        private static string CreateRowValues<TEntity>(IEnumerable<IProperty> properties, TEntity row)
            where TEntity : IBaseEntity =>
            (from property in properties
                let value = row.GetType().GetProperty(property.Name)?.GetValue(row)
                select FormatDataForMySql(property, value)).Aggregate("",
                (rowValues, value) => rowValues == "" ? "(" + value : rowValues + ", " + value) + ")";

        private static object FormatDataForMySql(IProperty property, object value)
        {
            if (value == null)
                return "NULL";
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
            if (update == "")
                update = GetUpdateUnchangedColumnHack(properties);
            return update;
        }

        private static string GetUpdateUnchangedColumnHack(IEnumerable<IProperty> properties)
        {
            var firstId = properties.First(x => x.IsPrimaryKey()).Name;
            return firstId + " = VALUES(" + firstId + ")";
        }

        private static async Task SetDefaultLicenseIdAsync(DbContext dbContext)
        {
            var listsWithoutLicense = dbContext.Set<FilterList>()
                                               .Where(l => l.LicenseId == null)
                                               .ToList()
                                               .Select(l =>
                                               {
                                                   l.LicenseId = 5;
                                                   return l;
                                               });
            dbContext.UpdateRange(listsWithoutLicense);
            await dbContext.SaveChangesAsync();
        }
    }
}