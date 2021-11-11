namespace FilterLists.Archival.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
