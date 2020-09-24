using System;

namespace FilterLists.Archival.Infrastructure.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
