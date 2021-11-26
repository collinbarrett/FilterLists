using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Change
{
    public long Id { get; private init; }
    public string? Reason { get; private init; }
    public DateTime SubmittedAt { get; private init; }
    public DateTime? ApprovedAt { get; private init; }
    public DateTime? RejectedAt { get; private init; }
    public string? RejectedReason { get; private init; }
    public JsonDocument? Before { get; private init; }
    public JsonDocument? After { get; private init; }
    public AggregateType AggregateType { get; private init; }
    public long? FilterListId { get; private init; }
    public FilterList? FilterList { get; }
    public long? LanguageId { get; private init; }
    public Language? Language { get; }
    public long? LicenseId { get; private init; }
    public License? License { get; }
    public long? MaintainerId { get; private init; }
    public Maintainer? Maintainer { get; }
    public long? SoftwareId { get; private init; }
    public Software? Software { get; }
    public long? SyntaxId { get; private init; }
    public Syntax? Syntax { get; }
    public long? TagId { get; private init; }
    public Tag? Tag { get; }
}

internal class UpdateConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        builder.Property(c => c.SubmittedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}
