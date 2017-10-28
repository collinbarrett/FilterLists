using FilterLists.Data.Entities;
using FilterLists.Data.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data
{
    public class FilterListsDbContext : DbContext
    {
        public FilterListsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<FilterList> FilterLists { get; set; }
        public DbSet<Maintainer> Maintainers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Software> Software { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilterListTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaintainerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoftwareTypeConfiguration());

            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListSoftwareTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}