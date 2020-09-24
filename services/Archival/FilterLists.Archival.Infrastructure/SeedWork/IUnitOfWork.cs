using System;

namespace FilterLists.SharedKernel.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
