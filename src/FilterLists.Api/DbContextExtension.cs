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
            if (context.FilterLists.Any()) return;
            Seed<License>(context);
            Seed<Syntax>(context);
            Seed<FilterList>(context);
        }

        private static void Seed<T>(DbContext context)
        {
            var rows = JsonConvert.DeserializeObject<List<T>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(T).Name + ".json"));
            context.AddRange(rows);
            context.SaveChanges();
        }
    }
}