using System.Globalization;
using System.Text.Json;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Change
{
    public int Id { get; private init; }
    public string? Reason { get; private init; }
    public DateTime SubmittedAt { get; private init; }
    public DateTime? ApprovedAt { get; private init; }
    public DateTime? RejectedAt { get; private init; }
    public string? RejectedReason { get; private init; }
    public JsonDocument? AggregateBefore { get; private init; }
    public JsonDocument? AggregateAfter { get; private init; }
    public AggregateType? AggregateType { get; private init; }
    public int? FilterListId { get; private init; }
    public FilterList? FilterList { get; }
    public string? LanguageIso6391 { get; private init; }
    public Language? Language { get; }
    public int? LicenseId { get; private init; }
    public License? License { get; }
    public int? MaintainerId { get; private init; }
    public Maintainer? Maintainer { get; }
    public int? SoftwareId { get; private init; }
    public Software? Software { get; }
    public int? SyntaxId { get; private init; }
    public Syntax? Syntax { get; }
    public int? TagId { get; private init; }
    public Tag? Tag { get; }
}

internal class UpdateConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        builder.Property(c => c.SubmittedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder
            .Property(c => c.AggregateType)
            .HasComputedColumnSql(BuildComputedAggregateTypeSql(), true);

        static string BuildComputedAggregateTypeSql()
        {
            // TODO: register and resolve INameRewriter
            var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);
            return $@"
                CASE 
                    WHEN {nr.RewriteName(nameof(Change.FilterListId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.FilterList))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.LanguageIso6391))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.Language))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.LicenseId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.License))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.MaintainerId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.Maintainer))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.SoftwareId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.Software))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.SyntaxId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.Syntax))}'::{nr.RewriteName(nameof(AggregateType))}
                    WHEN {nr.RewriteName(nameof(Change.TagId))} IS NOT NULL THEN '{nr.RewriteName(nameof(AggregateType.Tag))}'::{nr.RewriteName(nameof(AggregateType))}
                    ELSE NULL
                END";
        }
    }
}
