using FilterLists.Data.Models.Contracts;
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

        public DbSet<FilterList> FilterList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IBaseEntity>()
                .Property(b => b.CreatedDateUtc)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}