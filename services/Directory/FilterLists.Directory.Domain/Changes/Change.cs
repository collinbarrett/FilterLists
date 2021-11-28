using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Changes;

public abstract class Change : Entity
{
    public string? Reason { get; protected init; }
    public DateTime SubmittedAt { get; protected init; } = DateTime.UtcNow;
    public DateTime? ApprovedAt { get; private set; }
    public DateTime? RejectedAt { get; private set; }
    public string? RejectedReason { get; private set; }

    public void Approve()
    {
        ApprovedAt = DateTime.UtcNow;
    }

    public void Reject(string? reason)
    {
        RejectedAt = DateTime.UtcNow;
        RejectedReason = reason;
    }
}
