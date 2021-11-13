using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Change
{
    public int Id { get; init; }
    public ChangeType Type { get; init; }
    public JsonDocument? AggregateBefore { get; init; }
    public JsonDocument? AggregateAfter { get; init; }
    public string? Reason { get; init; }
    public DateTime SubmittedAt { get; init; }
    public DateTime? AppliedAt { get; init; }
    public DateTime? RejectedAt { get; init; }
    public string? RejectedReason { get; init; }
    public int? FilterListId { get; init; }
    public FilterList? FilterList { get; }
    public string? LanguageIso6391 { get; init; }
    public Language? Language { get; }
    public int? LicenseId { get; init; }
    public License? License { get; }
    public int? MaintainerId { get; init; }
    public Maintainer? Maintainer { get; }
    public int? SoftwareId { get; init; }
    public Software? Software { get; }
    public int? SyntaxId { get; init; }
    public Syntax? Syntax { get; }
    public int? TagId { get; init; }
    public Tag? Tag { get; }
}

internal class UpdateConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
    }
}
