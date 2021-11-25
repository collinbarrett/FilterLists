namespace FilterLists.SharedKernel.Domain.SeedWork;

public interface IUnitOfWork : IDisposable
{
    void Commit();
}
