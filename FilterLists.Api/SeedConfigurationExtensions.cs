using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api;

internal static class SeedConfigurationExtensions
{
    public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder) where TEntity : class
    {
        var entities = Deserialize<TEntity>();
        if (entities.Count == 0) return;

        entityTypeBuilder.HasData(entities);
    }

    public static void HasDataJsonFile<TEntity>(this OwnedNavigationBuilder ownedNavigationBuilder)
        where TEntity : class
    {
        var entities = Deserialize<TEntity>();
        if (entities.Count == 0) return;

        ownedNavigationBuilder.HasData(entities);
    }

    private static List<TEntity> Deserialize<TEntity>()
    {
        // uncomment to short-circuit HasData() when adding a migration
        return new List<TEntity>();

        var path = Path.Combine("../data", $"{typeof(TEntity).Name}.json");
        if (!File.Exists(path)) return new List<TEntity>();

        var entitiesJson = File.ReadAllText(path);
        var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(
            entitiesJson,
            new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        return entities is null ? new List<TEntity>() : entities.ToList();
    }
}