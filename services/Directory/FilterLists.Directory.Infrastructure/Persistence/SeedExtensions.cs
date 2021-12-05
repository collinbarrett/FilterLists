using System.Text.Json;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure.Persistence;

public static class SeedExtension
{
    public static async Task MigrateAsync(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<QueryDbContext>();
        await db.Database.MigrateAsync();

        // TODO: sometimes throws System.ObjectDisposedException, but sometimes needed for https://www.npgsql.org/efcore/mapping/enum.html#creating-your-database-enum
        //await using var conn = (NpgsqlConnection)db.Database.GetDbConnection();
        //await conn.OpenAsync();
        //conn.ReloadTypes();
    }
}

internal static class SeedConfigurationExtension
{
    public static void HasDataJsonFileEntityRequiringApproval<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        where TEntity : EntityRequiringApproval
    {
        var entities = Deserialize<TEntity>();
        if (entities.Count == 0)
        {
            return;
        }

        foreach (var entity in entities)
        {
            entity.Approve();
        }

        entityTypeBuilder.HasData(entities);
    }

    public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder) where TEntity : class
    {
        var entities = Deserialize<TEntity>();
        if (entities.Count == 0)
        {
            return;
        }

        entityTypeBuilder.HasData(entities);
    }

    public static void HasDataJsonFile<TEntity>(this OwnedNavigationBuilder ownedNavigationBuilder) where TEntity : class
    {
        var entities = Deserialize<TEntity>();
        if (entities.Count == 0)
        {
            return;
        }

        ownedNavigationBuilder.HasData(entities);
    }

    private static List<TEntity> Deserialize<TEntity>()
    {
        // uncomment to short-circuit HasData() when adding a migration
        //return new List<TEntity>();

        var path = Path.Combine("../data", $"{typeof(TEntity).Name}.json");
        if (!File.Exists(path))
        {
            return new List<TEntity>();
        }

        var entitiesJson = File.ReadAllText(path);
        var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(
            entitiesJson,
            new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        return entities is null ? new List<TEntity>() : entities.ToList();
    }

    private static void Approve<TEntityRequiringApproval>(this TEntityRequiringApproval entity)
        where TEntityRequiringApproval : EntityRequiringApproval
    {
        entity.IsApproved = true;
    }
}
