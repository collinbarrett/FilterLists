using FilterLists.Data.Entities;
using FilterLists.Data.EntityTypeConfigurations;
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
            modelBuilder.ApplyConfiguration(new FilterListConfiguration());
            modelBuilder.ApplyConfiguration(new MaintainerConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        }
    }
}