using System;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings;
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

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new InvalidOperationException("This context is read-only.");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new InvalidOperationException("This context is read-only.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            //TODO: figure out why this extension doesn't load configs
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.ApplyConfiguration(new DependentTypeConfiguration<Dependent>());
            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration<FilterListLanguage>());
            modelBuilder.ApplyConfiguration(new ForkTypeConfiguration<Fork>());
            modelBuilder.ApplyConfiguration(new MergeTypeConfiguration<Merge>());
        }
    }
}