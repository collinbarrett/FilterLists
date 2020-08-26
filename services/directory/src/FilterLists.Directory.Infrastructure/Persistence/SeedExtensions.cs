using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence
{
    internal static class SeedExtensions
    {
        public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        {
            _ = entityTypeBuilder ?? throw new ArgumentNullException(nameof(entityTypeBuilder));
            var entities = GetEntities<TEntity>();
            entityTypeBuilder.HasData((IEnumerable<object>)entities);
        }

        public static void HasDataJsonFile<TEntity>(this OwnedNavigationBuilder ownedNavigationBuilder)
        {
            _ = ownedNavigationBuilder ?? throw new ArgumentNullException(nameof(ownedNavigationBuilder));
            var entities = GetEntities<TEntity>();
            ownedNavigationBuilder.HasData((IEnumerable<object>)entities);
        }

        private static IEnumerable<TEntity> GetEntities<TEntity>()
        {
            var path = Path.Combine("../../../data", $"{typeof(TEntity).Name}.json");
            if (!File.Exists(path)) return new HashSet<TEntity>();

            var entitiesJson = File.ReadAllText(path);
            var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(entitiesJson, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return entities;
        }
    }
}