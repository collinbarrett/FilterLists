using System;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries
{
    internal class DirectoryQueryFacade : IQueryDirectory, IAsyncDisposable
    {
        private readonly DirectoryQueryDbContext _db;

        public DirectoryQueryFacade()
        {
            _db = new DirectoryQueryDbContext();
        }

        public async ValueTask DisposeAsync()
        {
            await _db.DisposeAsync();
        }

        public IQueryable<FilterList> FilterLists => _db.FilterLists.AsNoTracking();
        public IQueryable<Language> Languages => _db.Languages.AsNoTracking();
        public IQueryable<License> Licenses => _db.Licenses.AsNoTracking();
        public IQueryable<Maintainer> Maintainers => _db.Maintainers.AsNoTracking();
        public IQueryable<Software> Software => _db.Software.AsNoTracking();
        public IQueryable<Syntax> Syntaxes => _db.Syntaxes.AsNoTracking();
        public IQueryable<Tag> Tags => _db.Tags.AsNoTracking();
    }
}