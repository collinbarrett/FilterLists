using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Data.EntityTypeConfigurations;
using FilterLists.Data.EntityTypeConfigurations.Junctions;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data
{
    public class FilterListsDbContext : DbContext
    {
        public FilterListsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfigurationsEntities(modelBuilder);
            ApplyConfigurationsJunctions(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private static void ApplyConfigurationsEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilterListTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LicenseTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaintainerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RuleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SnapshotTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoftwareTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SyntaxTypeConfiguration());
        }

        private static void ApplyConfigurationsJunctions(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListMaintainerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListRuleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ForkTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MergeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoftwareSyntaxTypeConfiguration());
        }

        #region Entities

        public DbSet<FilterList> FilterLists { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Maintainer> Maintainers { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Snapshot> Snapshots { get; set; }
        public DbSet<Software> Software { get; set; }
        public DbSet<Syntax> Syntaxes { get; set; }

        #endregion

        #region Junctions

        public DbSet<FilterListLanguage> FilterListLanguages { get; set; }
        public DbSet<FilterListMaintainer> FilterListMaintainers { get; set; }
        public DbSet<FilterListRule> FilterListRules { get; set; }
        public DbSet<Fork> Forks { get; set; }
        public DbSet<Merge> Merges { get; set; }
        public DbSet<SoftwareSyntax> SoftwareSyntaxes { get; set; }

        #endregion
    }
}