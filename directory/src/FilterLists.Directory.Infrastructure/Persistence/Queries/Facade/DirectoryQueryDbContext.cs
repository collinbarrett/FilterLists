using System;
using System.Threading;
using System.Threading.Tasks;
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

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new InvalidOperationException("This context is read-only.");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            throw new InvalidOperationException("This context is read-only.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            // TODO: rm explicit below once ApplyConfigurationsFromAssembly() works properly
            modelBuilder.ApplyConfiguration(new DependentTypeConfiguration<Dependent>());
            modelBuilder.ApplyConfiguration(new FilterListTypeConfiguration<FilterList>());
            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration<FilterListLanguage>());
            modelBuilder.ApplyConfiguration(new FilterListMaintainerTypeConfiguration<FilterListMaintainer>());
            modelBuilder.ApplyConfiguration(new FilterListSyntaxTypeConfiguration<FilterListSyntax>());
            modelBuilder.ApplyConfiguration(new FilterListTagTypeConfiguration<FilterListTag>());
            modelBuilder.ApplyConfiguration(new ForkTypeConfiguration<Fork>());
            modelBuilder.ApplyConfiguration(new LanguageTypeConfiguration<Language>());
            modelBuilder.ApplyConfiguration(new LicenseTypeConfiguration<License>());
            modelBuilder.ApplyConfiguration(new MaintainerTypeConfiguration<Maintainer>());
            modelBuilder.ApplyConfiguration(new MergeTypeConfiguration<Merge>());
            modelBuilder.ApplyConfiguration(new SoftwareTypeConfiguration<Software>());
            modelBuilder.ApplyConfiguration(new SoftwareSyntaxTypeConfiguration<SoftwareSyntax>());
            modelBuilder.ApplyConfiguration(new SyntaxTypeConfiguration<Syntax>());
            modelBuilder.ApplyConfiguration(new TagTypeConfiguration<Tag>());
            modelBuilder.ApplyConfiguration(new ViewUrlMirrorTypeConfiguration<ViewUrlMirror>());
            modelBuilder.ApplyConfiguration(new ViewUrlPartialTypeConfiguration<ViewUrlPartial>());
        }
    }
}