using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Infrastructure.Persistence
{
    public static class SeedExtension
    {
        public static async Task MigrateAsync(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<QueryDbContext>();
            await db.Database.MigrateAsync();
        }
    }

    internal static class SeedConfigurationExtension
    {
        public static void HasDataJsonFile<TEntity>(this EntityTypeBuilder entityTypeBuilder)
        {
            var path = Path.Combine("../data", $"{typeof(TEntity).Name}.json");
            if (!File.Exists(path))
            {
                return;
            }

            var entitiesJson = File.ReadAllText(path);
            var entities = JsonSerializer.Deserialize<IEnumerable<TEntity>>(entitiesJson,
                new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            if (entities != null)
            {
                entityTypeBuilder.HasData((IEnumerable<object>)entities);
            }
        }
    }
}
