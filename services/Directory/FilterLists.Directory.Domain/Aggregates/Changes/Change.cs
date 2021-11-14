namespace FilterLists.Directory.Domain.Aggregates.Changes;

public abstract class Change
{
    public string? Reason { get; init; }
    public DateTime SubmittedAt { get; init; } = DateTime.UtcNow;
    public DateTime? AppliedAt { get; private set; }
    public DateTime? RejectedAt { get; private set; }
    public string? RejectedReason { get; private set; }

    public void Approve()
    {
        AppliedAt = DateTime.UtcNow;
    }

    public void Reject(string? reason)
    {
        RejectedAt = DateTime.UtcNow;
        RejectedReason = reason;
    }
}
