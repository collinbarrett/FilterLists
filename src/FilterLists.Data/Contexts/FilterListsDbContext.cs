using System;
using System.Linq;
using System.Reflection;
using FilterLists.Data.Entities;
using FilterLists.Data.EntityMaps;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Contexts
{
    public class FilterListsDbContext : DbContext, IFilterListsDbContext
    {
        public FilterListsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<FilterList> FilterLists { get; set; }
        public DbSet<Maintainer> Maintainers { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RegisterMaps(modelBuilder);
        }

        private static void RegisterMaps(ModelBuilder modelBuilder)
        {
            var entityMaps = typeof(FilterList).GetTypeInfo().Assembly.GetTypes().Where(type =>
                    !string.IsNullOrWhiteSpace(type.Namespace) && typeof(IEntityMap).IsAssignableFrom(type) &&
                    type.IsClass)
                .ToList();

            foreach (var entityMap in entityMaps)
                Activator.CreateInstance(entityMap, BindingFlags.Public | BindingFlags.Instance, null,
                    new object[] {modelBuilder}, null);
        }
    }
}