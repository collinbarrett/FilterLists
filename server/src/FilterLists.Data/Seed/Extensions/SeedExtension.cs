using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.Seed.Extensions
{
    public static class SeedExtension
    {
        public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        {
            string path = Path.Combine("../../../data", $"{typeof(TEntity).Name}.json");
            if (File.Exists(path))
            {
                var entitiesJson = File.ReadAllText(path);
                var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(entitiesJson, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
                entityTypeBuilder.HasData((IEnumerable<object>)entities);
            }
        }
    }
}