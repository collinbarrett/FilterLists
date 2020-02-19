using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Ardalis.GuardClauses;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.Seed.Extensions
{
    public static class SeedExtension
    {
        public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        {
            Guard.Against.Null(entityTypeBuilder, nameof(entityTypeBuilder));

            var path = Path.Combine("../../../data", $"{typeof(TEntity).Name}.json");
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