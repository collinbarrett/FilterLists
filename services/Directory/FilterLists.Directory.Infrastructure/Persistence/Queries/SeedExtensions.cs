using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries;

internal static class SeedConfigurationExtensions
{
    private static readonly JsonSerializerOptions CamelCaseJsonSerializerOptions =
        new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

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
        // return new List<TEntity>();

        var path = Path.Combine("../data", $"{typeof(TEntity).Name}.json");
        if (!File.Exists(path)) return [];

        var entitiesJson = File.ReadAllText(path);
        var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(
            entitiesJson,
            CamelCaseJsonSerializerOptions);
        return entities is null ? [] : entities.ToList();
    }
}