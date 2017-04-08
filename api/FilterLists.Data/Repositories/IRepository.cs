//https://code.msdn.microsoft.com/Generic-Repository-Pattern-f133bca4/sourcecode?fileId=164016&pathId=804969589

using System.Collections.Generic;
using FilterLists.Models;

namespace FilterLists.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}