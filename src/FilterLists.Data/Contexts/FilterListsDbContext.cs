using FilterLists.Data.Models.Implementations;
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
            modelBuilder.Entity<Maintainer>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<FilterList>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Language>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}