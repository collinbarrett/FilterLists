using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence
{
    internal static class SeedExtensions
    {
        public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        {
            _ = entityTypeBuilder ?? throw new ArgumentNullException(nameof(entityTypeBuilder));

            // TODO: fix seeding FilterListViewUrl
            if (typeof(TEntity).Name == nameof(FilterListViewUrl))
                return;

            var path = Path.Combine("../../data", $"{typeof(TEntity).Name}.json");
            if (!File.Exists(path)) return;

            var entitiesJson = File.ReadAllText(path);
            var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(entitiesJson, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            entityTypeBuilder.HasData((IEnumerable<object>)entities);
        }
    }
}