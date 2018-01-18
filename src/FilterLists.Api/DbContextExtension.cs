// https://garywoodfine.com/how-to-seed-your-ef-core-database/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using FilterLists.Data;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;

namespace FilterLists.Api
{
    public static class DbContextExtension
    {
        private const string SeedDirectory = "Seed";

        public static bool AllMigrationsApplied(this DbContext context)
        {
            var appliedMigrationIds = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);
            var allMigrationKeys = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);
            return !allMigrationKeys.Except(appliedMigrationIds).Any();
        }

        public static void EnsureSeeded(this FilterListsDbContext context)
        {
            SeedLicenses(context);
            SeedSyntaxes(context);
            SeedFilterLists(context);
        }

        //TODO: fix generic method to remove duplication of entity-specific methods
        private static void Seed<T>(DbContext context)
        {
            //if (context.?.Any()) return;
            var rows = JsonConvert.DeserializeObject<List<T>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(T).Name + ".json"));
            context.AddRange(rows);
            context.SaveChanges();
        }

        private static void SeedLicenses(FilterListsDbContext context)
        {
            if (context.Licenses.Any()) return;
            var types = JsonConvert.DeserializeObject<List<License>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(License).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedSyntaxes(FilterListsDbContext context)
        {
            if (context.Syntaxes.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Syntax>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Syntax).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedFilterLists(FilterListsDbContext context)
        {
            if (context.FilterLists.Any()) return;
            var types = JsonConvert.DeserializeObject<List<FilterList>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(FilterList).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }
    }
}