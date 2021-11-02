using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "ReplaceAutoPropertyWithComputedProperty")]
    public class FilterListSyntax
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; } = null!;
        public int SyntaxId { get; private set; }
        public Syntax Syntax { get; } = null!;
    }

    internal class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListSyntax> builder)
        {
            builder.ToTable(nameof(FilterListSyntax) + "es");
            builder.HasKey(fls => new { fls.FilterListId, fls.SyntaxId });
            builder.HasDataJsonFile<FilterListSyntax>();
        }
    }
}
