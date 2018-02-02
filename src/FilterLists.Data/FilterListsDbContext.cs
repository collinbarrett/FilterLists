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
            modelBuilder.ApplyConfiguration(new ScrapeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SoftwareTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SyntaxTypeConfiguration());
        }

        private static void ApplyConfigurationsJunctions(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilterListLanguageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListMaintainerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FilterListRuleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ForkTypeConfiguration());
            ConfigureForkSelfReferencing(modelBuilder);
            modelBuilder.ApplyConfiguration(new MergeTypeConfiguration());
            ConfigureMergeSelfReferencing(modelBuilder);
            modelBuilder.ApplyConfiguration(new SoftwareSyntaxTypeConfiguration());
        }

        private static void ConfigureForkSelfReferencing(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fork>()
                .HasOne(x => x.ForkFilterList)
                .WithMany(x => x.ForkFilterLists)
                .HasForeignKey(x => x.ForkFilterListId);
            modelBuilder.Entity<Fork>()
                .HasOne(x => x.UpstreamFilterList)
                .WithMany(x => x.UpstreamForkFilterLists)
                .HasForeignKey(x => x.UpstreamFilterListId);
        }

        private static void ConfigureMergeSelfReferencing(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merge>()
                .HasOne(x => x.MergeFilterList)
                .WithMany(x => x.MergeFilterLists)
                .HasForeignKey(x => x.MergeFilterListId);
            modelBuilder.Entity<Merge>()
                .HasOne(x => x.UpstreamFilterList)
                .WithMany(x => x.UpstreamMergeFilterLists)
                .HasForeignKey(x => x.UpstreamFilterListId);
        }

        #region Entities

        public DbSet<FilterList> FilterLists { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Maintainer> Maintainers { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Scrape> Scrapes { get; set; }
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