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
            SeedEntities(context);
            SeedJunctions(context);
        }

        private static void SeedEntities(FilterListsDbContext context)
        {
            SeedLanguages(context);
            SeedLicenses(context);
            SeedMaintainers(context);
            SeedSoftware(context);
            SeedSyntaxes(context);
            SeedFilterLists(context);
        }

        private static void SeedJunctions(FilterListsDbContext context)
        {
            SeedFilterListLanguages(context);
            SeedFilterListMaintainers(context);
            SeedForks(context);
            SeedMerges(context);
            SeedSoftwareSyntaxes(context);
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

        #region Entities

        private static void SeedFilterLists(FilterListsDbContext context)
        {
            if (context.FilterLists.Any()) return;
            var types = JsonConvert.DeserializeObject<List<FilterList>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(FilterList).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedLanguages(FilterListsDbContext context)
        {
            if (context.Languages.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Language>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Language).Name + ".json"));
            context.AddRange(types);
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

        private static void SeedMaintainers(FilterListsDbContext context)
        {
            if (context.Maintainers.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Maintainer>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Maintainer).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedSoftware(FilterListsDbContext context)
        {
            if (context.Software.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Software>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Software).Name + ".json"));
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

        #endregion

        #region Junctions

        private static void SeedFilterListLanguages(FilterListsDbContext context)
        {
            if (context.FilterListLanguages.Any()) return;
            var types = JsonConvert.DeserializeObject<List<FilterListLanguage>>(
                File.ReadAllText(
                    SeedDirectory + Path.DirectorySeparatorChar + typeof(FilterListLanguage).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedFilterListMaintainers(FilterListsDbContext context)
        {
            if (context.FilterListMaintainers.Any()) return;
            var types = JsonConvert.DeserializeObject<List<FilterListMaintainer>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(FilterListMaintainer).Name +
                                 ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedForks(FilterListsDbContext context)
        {
            if (context.Forks.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Fork>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Fork).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedMerges(FilterListsDbContext context)
        {
            if (context.Merges.Any()) return;
            var types = JsonConvert.DeserializeObject<List<Merge>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(Merge).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedSoftwareSyntaxes(FilterListsDbContext context)
        {
            if (context.SoftwareSyntaxes.Any()) return;
            var types = JsonConvert.DeserializeObject<List<SoftwareSyntax>>(
                File.ReadAllText(SeedDirectory + Path.DirectorySeparatorChar + typeof(SoftwareSyntax).Name + ".json"));
            context.AddRange(types);
            context.SaveChanges();
        }

        #endregion
    }
}