using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: SuppressMessage("Design", "RCS1170", Justification = "EF Core: Properties without setters are not mapped by convention.", Scope = "NamespaceAndDescendants", Target = "~N:FilterLists.Directory.Infrastructure.Persistence.Queries.Entities")]
[assembly: SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "ReSharper false positives.", Scope = "NamespaceAndDescendants", Target = "~N:FilterLists.Directory.Infrastructure.Persistence.Queries.Entities")]
namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "ReplaceAutoPropertyWithComputedProperty")]
    public class Dependent
    {
        public int DependencyFilterListId { get; private set; }
        public FilterList DependencyFilterList { get; } = null!;
        public int DependentFilterListId { get; private set; }
        public FilterList DependentFilterList { get; } = null!;
    }

    internal class DependentTypeConfiguration : IEntityTypeConfiguration<Dependent>
    {
        public virtual void Configure(EntityTypeBuilder<Dependent> builder)
        {
            builder.ToTable(nameof(Dependent) + "s");
            builder.HasKey(d => new { d.DependencyFilterListId, d.DependentFilterListId });
            builder.HasOne(d => d.DependencyFilterList)
                .WithMany(fl => fl.DependentFilterLists)
                .HasForeignKey(d => d.DependencyFilterListId);
            builder.HasOne(d => d.DependentFilterList)
                .WithMany(fl => fl.DependencyFilterLists)
                .HasForeignKey(d => d.DependentFilterListId);
            builder.HasDataJsonFile<Dependent>();
        }
    }
}
