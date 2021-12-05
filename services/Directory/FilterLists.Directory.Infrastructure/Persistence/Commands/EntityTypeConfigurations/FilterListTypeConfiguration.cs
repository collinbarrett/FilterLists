using System.Globalization;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilterList = FilterLists.Directory.Domain.Aggregates.FilterLists.FilterList;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public virtual void Configure(EntityTypeBuilder<FilterList> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.HasMany(f => f.Syntaxes)
            .WithMany(s => s.FilterLists)
            .UsingEntity(
                nameof(FilterListSyntax),
                e =>
                {
                    e.ToTable($"{nr.RewriteName(nameof(FilterListSyntax))}es");
                    e.Property<long>(nameof(FilterListSyntax.FilterListId));
                    e.Property<long>(nameof(FilterListSyntax.SyntaxId));
                    e.HasKey(nameof(FilterListSyntax.FilterListId), nameof(FilterListSyntax.SyntaxId));
                });
        builder.HasMany(f => f.Languages)
            .WithMany(l => l.FilterLists)
            .UsingEntity(
                nameof(FilterListLanguage),
                e =>
                {
                    e.ToTable($"{nr.RewriteName(nameof(FilterListLanguage))}s");
                    e.Property<long>(nameof(FilterListLanguage.FilterListId));
                    e.Property<long>(nameof(FilterListLanguage.LanguageId));
                    e.HasKey(nameof(FilterListLanguage.FilterListId), nameof(FilterListLanguage.LanguageId));
                });
        builder.HasMany(f => f.Tags)
            .WithMany(t => t.FilterLists)
            .UsingEntity(
                nameof(FilterListTag),
                e =>
                {
                    e.ToTable($"{nr.RewriteName(nameof(FilterListTag))}s");
                    e.Property<long>(nameof(FilterListTag.FilterListId));
                    e.Property<long>(nameof(FilterListTag.TagId));
                    e.HasKey(nameof(FilterListTag.FilterListId), nameof(FilterListTag.TagId));
                });
        builder.OwnsMany(
            f => f.ViewUrls,
            b =>
            {
                b.ToTable($"{nr.RewriteName(nameof(FilterListViewUrl))}s");
                b.Property(u => u.SegmentNumber)
                    .HasDefaultValue(1);
                b.Property(u => u.Primariness)
                    .HasDefaultValue(1);
                b.HasIndex(
                        nameof(FilterListViewUrl.FilterListId),
                        nameof(FilterListViewUrl.SegmentNumber),
                        nameof(FilterListViewUrl.Primariness))
                    .IsUnique();
            });
        builder.Navigation(f => f.ViewUrls)
            .AutoInclude();
        builder.HasMany(f => f.Maintainers)
            .WithMany(m => m.FilterLists)
            .UsingEntity(
                nameof(FilterListMaintainer),
                e =>
                {
                    e.ToTable($"{nr.RewriteName(nameof(FilterListMaintainer))}s");
                    e.Property<long>(nameof(FilterListMaintainer.FilterListId));
                    e.Property<long>(nameof(FilterListMaintainer.MaintainerId));
                    e.HasKey(nameof(FilterListMaintainer.FilterListId), nameof(FilterListMaintainer.MaintainerId));
                });
        builder.HasMany(f => f.UpstreamFilterLists)
            .WithMany(f => f.ForkFilterLists)
            .UsingEntity<Dictionary<string, object>>(
                nameof(Fork),
                rj => rj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Fork.UpstreamFilterListId)),
                lj => lj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Fork.ForkFilterListId)),
                e => e.ToTable($"{nr.RewriteName(nameof(Fork))}s"));
        builder.HasMany(f => f.IncludedInFilterLists)
            .WithMany(f => f.IncludesFilterLists)
            .UsingEntity<Dictionary<string, object>>(
                nameof(Merge),
                rj => rj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Merge.IncludedInFilterListId)),
                lj => lj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Merge.IncludesFilterListId)),
                e => e.ToTable($"{nr.RewriteName(nameof(Merge))}s"));
        builder.HasMany(f => f.DependencyFilterLists)
            .WithMany(f => f.DependentFilterLists)
            .UsingEntity<Dictionary<string, object>>(
                nameof(Dependent),
                rj => rj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Dependent.DependencyFilterListId)),
                lj => lj
                    .HasOne<FilterList>()
                    .WithMany()
                    .HasForeignKey(nameof(Dependent.DependentFilterListId)),
                e => e.ToTable($"{nr.RewriteName(nameof(Dependent))}s"));
        builder.HasMany(f => f.Changes)
            .WithOne()
            .HasForeignKey(nameof(Change.FilterListId));
        builder.Navigation(f => f.Changes)
            .AutoInclude();
    }
}
