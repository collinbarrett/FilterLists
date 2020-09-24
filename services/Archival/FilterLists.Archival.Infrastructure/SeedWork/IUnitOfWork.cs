using System;

namespace FilterLists.Archival.Infrastructure.SeedWork
{
    internal interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
