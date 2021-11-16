using System.Globalization;
using System.Text.Json;
using EFCore.NamingConventions.Internal;
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
    public string? AggregateType { get; private init; }
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

internal enum AggregateType
{
    FilterList,
    Language,
    License,
    Maintainer,
    Software,
    Syntax,
    Tag
}

internal class UpdateConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        builder
            .Property(c => c.AggregateType)
            .HasComputedColumnSql(BuildComputedAggregateTypeSql(), true);

        static string BuildComputedAggregateTypeSql()
        {
            var nameRewriter = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);
            return $@"
                CASE 
                    WHEN {nameRewriter.RewriteName(nameof(Change.FilterListId))} IS NOT NULL THEN '{AggregateType.FilterList}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.LanguageIso6391))} IS NOT NULL THEN '{AggregateType.Language}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.LicenseId))} IS NOT NULL THEN '{AggregateType.License}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.MaintainerId))} IS NOT NULL THEN '{AggregateType.Maintainer}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.SoftwareId))} IS NOT NULL THEN '{AggregateType.Software}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.SyntaxId))} IS NOT NULL THEN '{AggregateType.Syntax}'
                    WHEN {nameRewriter.RewriteName(nameof(Change.TagId))} IS NOT NULL THEN '{AggregateType.Tag}'
                    ELSE NULL
                END";
        }
    }
}
