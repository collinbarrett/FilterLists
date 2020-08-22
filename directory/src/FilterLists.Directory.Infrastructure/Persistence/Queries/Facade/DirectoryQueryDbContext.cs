using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Facade
{
    internal class DirectoryQueryDbContext : DbContext
    {
        public DirectoryQueryDbContext(DbContextOptions<DirectoryQueryDbContext> options) : base(options)
        {
        }

        public DbSet<FilterList> FilterLists => Set<FilterList>();
        public DbSet<Language> Languages => Set<Language>();
        public DbSet<License> Licenses => Set<License>();
        public DbSet<Maintainer> Maintainers => Set<Maintainer>();
        public DbSet<Software> Software => Set<Software>();
        public DbSet<Syntax> Syntaxes => Set<Syntax>();
        public DbSet<Tag> Tags => Set<Tag>();
    }
}