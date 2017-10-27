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

        public DbSet<FilterListLanguage> FilterListLanguages { get; set; }


        public DbSet<FilterList> FilterLists { get; set; }
        public DbSet<Maintainer> Maintainers { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilterListTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaintainerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}