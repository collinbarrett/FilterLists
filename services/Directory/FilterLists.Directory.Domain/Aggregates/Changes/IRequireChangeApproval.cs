namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IRequireChangeApproval<out TChange> where TChange : Change
{
    public IEnumerable<TChange> Changes { get; }
    public IEnumerable<TChange> PendingChanges => Changes.Where(c => c.ApprovedAt == null && c.RejectedAt == null);
    public IEnumerable<TChange> ApprovedChanges => Changes.Where(c => c.ApprovedAt != null);
    public IEnumerable<TChange> RejectedChanges => Changes.Where(c => c.RejectedAt != null);
    public bool IsApproved { get; }
}
