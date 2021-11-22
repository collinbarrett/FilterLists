namespace FilterLists.Directory.Domain.Aggregates.Changes;

public interface IRequireChangeApproval<out TChange> where TChange : Change
{
    public IReadOnlyCollection<TChange> Changes { get; }
    public IReadOnlyCollection<TChange> PendingChanges => (IReadOnlyCollection<TChange>)Changes.Where(c => c.ApprovedAt == null && c.RejectedAt == null);
    public IReadOnlyCollection<TChange> ApprovedChanges => (IReadOnlyCollection<TChange>)Changes.Where(c => c.ApprovedAt != null);
    public IReadOnlyCollection<TChange> RejectedChanges => (IReadOnlyCollection<TChange>)Changes.Where(c => c.RejectedAt != null);
    public bool IsApproved { get; }
}
