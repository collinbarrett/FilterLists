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
    public class SeedFilterListsDbContext
    {
        public async Task SeedOrUpdateAsync(FilterListsDbContext dbContext, string dataPath)
        {
           await SeedOrUpdateAsync<Language>(dbContext,dataPath);
           await SeedOrUpdateAsync<License>(dbContext, dataPath);
           await SeedOrUpdateAsync<Maintainer>(dbContext,dataPath);
           await SeedOrUpdateAsync<Software>(dbContext,dataPath);
           await SeedOrUpdateAsync<Syntax>(dbContext,dataPath);
           await SeedOrUpdateAsync<Tag>(dbContext,dataPath);
           await SeedOrUpdateAsync<FilterList>(dbContext,dataPath);
           await SetDefaultLicenseIdAsync(dbContext);
           await SeedOrUpdateAsync<FilterListLanguage>(dbContext,dataPath);
           await SeedOrUpdateAsync<FilterListMaintainer>(dbContext,dataPath);
           await SeedOrUpdateAsync<FilterListTag>(dbContext,dataPath);
           await SeedOrUpdateAsync<Dependent>(dbContext,dataPath);
           await SeedOrUpdateAsync<Fork>(dbContext,dataPath);
           await SeedOrUpdateAsync<Merge>(dbContext,dataPath);
           await SeedOrUpdateAsync<SoftwareSyntax>(dbContext,dataPath);
        }

        private async Task SeedOrUpdateAsync<TEntity>(DbContext dbContext, string dataPath)
            where TEntity : class, IBaseEntity
        {
            var seed = GetSeed<TEntity>(dataPath);
            await ApplyRemovals(dbContext, seed);
            await InsertOnDuplicateKeyUpdate(dbContext, seed);
        }

        private List<TEntity> GetSeed<TEntity>(string dataPath) where TEntity : IBaseEntity
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TEntity>>(
                    File.ReadAllText(Path.Combine(dataPath,typeof(TEntity).Name + ".json")));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return new List<TEntity>();
            }
        }

        private async Task ApplyRemovals<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : class
        {
            var removedEntities = GetRemovedEntities(dbContext, seed);
            dbContext.RemoveRange(removedEntities);
            await dbContext.SaveChangesAsync();
        }

        //https://stackoverflow.com/a/52264468/2343739
        private IEnumerable<TEntity> GetRemovedEntities<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
            where TEntity : class
        {
            var entityType = dbContext.Model.FindEntityType(typeof(TEntity));
            var dbEntity = Expression.Parameter(entityType.ClrType, "e");
            var matchesAnyPk = GetMatchesAnyPk(seed, entityType, dbEntity);
            var notInSeed = Expression.Lambda<Func<TEntity, bool>>(Expression.Not(matchesAnyPk), dbEntity);
            return dbContext.Set<TEntity>().Where(notInSeed);
        }

        private Expression GetMatchesAnyPk<TEntity>(IEnumerable<TEntity> seed, IEntityType entityType,
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

        private async Task InsertOnDuplicateKeyUpdate<TEntity>(DbContext dbContext, IEnumerable<TEntity> seed)
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

        private List<IProperty> GetPropertiesLessValueGeneratedTimestamps(IEntityType entityType) =>
            entityType.GetProperties()
                      .Where(x => !new List<string> {"CreatedDateUtc", "ModifiedDateUtc"}.Contains(x.Name))
                      .ToList();

        private string CreateValues<TEntity>(IEnumerable<TEntity> seed,
            IReadOnlyCollection<IProperty> properties) where TEntity : IBaseEntity =>
            seed.Select(row => CreateRowValues(properties, row))
                .Aggregate("", (current, rowValues) => current == "" ? rowValues : current + ", " + rowValues);

        private string CreateRowValues<TEntity>(IEnumerable<IProperty> properties, TEntity row)
            where TEntity : IBaseEntity =>
            (from property in properties
                let value = row.GetType().GetProperty(property.Name)?.GetValue(row)
                select FormatDataForMySql(property, value)).Aggregate("",
                (rowValues, value) => rowValues == "" ? "(" + value : rowValues + ", " + value) + ")";

        private object FormatDataForMySql(IProperty property, object value)
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

        private string CreateUpdates(IReadOnlyCollection<IProperty> properties)
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

        private string GetUpdateUnchangedColumnHack(IEnumerable<IProperty> properties)
        {
            var firstId = properties.First(x => x.IsPrimaryKey()).Name;
            return firstId + " = VALUES(" + firstId + ")";
        }

        private async Task SetDefaultLicenseIdAsync(DbContext dbContext)
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