using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListSyntax
    {
        public FilterList FilterList { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListSyntax> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            
            builder.ToTable(nameof(FilterListSyntax) + "es");

            const string filterListId = nameof(FilterListSyntax.FilterList) + "Id";
            const string syntaxId = nameof(FilterListSyntax.Syntax) + "Id";
            builder.Property<int>(filterListId);
            builder.Property<int>(syntaxId);
            builder.HasKey(filterListId, syntaxId);
        }
    }
}