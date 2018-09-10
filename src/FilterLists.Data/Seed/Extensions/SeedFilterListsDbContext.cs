using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;

namespace FilterLists.Data.Seed.Extensions
{
    public static class SeedFilterListsDbContext
    {
        public static void SeedOrUpdate(this FilterListsDbContext dbContext, string dataPath)
        {
            dbContext.SeedOrUpdate<Language>(dataPath);
            dbContext.SeedOrUpdate<License>(dataPath);
            dbContext.SeedOrUpdate<Maintainer>(dataPath);
            dbContext.SeedOrUpdate<Software>(dataPath);
            dbContext.SeedOrUpdate<Syntax>(dataPath);
            dbContext.SeedOrUpdate<Tag>(dataPath);
            dbContext.SeedOrUpdate<FilterList>(dataPath);
            dbContext.SeedOrUpdate<FilterListLanguage>(dataPath);
            dbContext.SeedOrUpdate<FilterListMaintainer>(dataPath);
            dbContext.SeedOrUpdate<FilterListTag>(dataPath);
            dbContext.SeedOrUpdate<Dependent>(dataPath);
            dbContext.SeedOrUpdate<Fork>(dataPath);
            dbContext.SeedOrUpdate<Merge>(dataPath);
            dbContext.SeedOrUpdate<SoftwareSyntax>(dataPath);
        }

        private static void SeedOrUpdate<TEntity>(this DbContext dbContext, string dataPath)
            where TEntity : class, IBaseEntity
        {
            var seed = GetSeed<TEntity>(dataPath);
            ApplyRemovals(dbContext, seed);
            InsertOnDuplicateKeyUpdate(dbContext, seed);
        }

        private static List<TEntity> GetSeed<TEntity>(string dataPath) where TEntity : IBaseEntity
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TEntity>>(
                    File.ReadAllText(dataPath + Path.DirectorySeparatorChar + typeof(TEntity).Name + ".json"));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return new List<TEntity>();
            }
        }

        private static void ApplyRemovals<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : class
        {
            var removedEntities = GetRemovedEntities(dbContext, seed);
            dbContext.RemoveRange(removedEntities);
            dbContext.SaveChanges();
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
            Expression dbEntity)
            where TEntity : class =>
            seed.Select(e => entityType.FindPrimaryKey()
                                       .Properties
                                       .Select(p => Expression.Equal(
                                           Expression.Property(dbEntity, p.PropertyInfo),
                                           Expression.Property(Expression.Constant(e), p.PropertyInfo)))
                                       .Aggregate(Expression.AndAlso))
                .Aggregate(null,
                    (Func<Expression, BinaryExpression, Expression>)((current, match) =>
                        current != null ? Expression.OrElse(current, match) : match));

        private static void InsertOnDuplicateKeyUpdate<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
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
            dbContext.Database.ExecuteSqlCommand(sql);
        }

        private static List<IProperty> GetPropertiesLessValueGeneratedTimestamps(IEntityType entityType) =>
            entityType.GetProperties()
                      .Where(x => !new List<string> {"CreatedDateUtc", "ModifiedDateUtc"}.Contains(x.Name))
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
    }
}