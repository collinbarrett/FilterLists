//https://code.msdn.microsoft.com/Generic-Repository-Pattern-f133bca4/sourcecode?fileId=164016&pathId=902500354

using System;
using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly FilterListsDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(FilterListsDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T Get(long id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}