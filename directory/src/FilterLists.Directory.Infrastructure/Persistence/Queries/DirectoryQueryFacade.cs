using System;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries
{
    public class DirectoryQueryFacade : IQueryDirectory, IAsyncDisposable
    {
        private readonly DirectoryQueryDbContext _dbContext;

        public DirectoryQueryFacade()
        {
            _dbContext = new DirectoryQueryDbContext();
        }

        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }

        public IQueryable<FilterList> FilterLists => _dbContext.FilterLists.AsNoTracking();
        public IQueryable<Language> Languages => _dbContext.Languages.AsNoTracking();
        public IQueryable<License> Licenses => _dbContext.Licenses.AsNoTracking();
        public IQueryable<Maintainer> Maintainers => _dbContext.Maintainers.AsNoTracking();
        public IQueryable<Software> Software => _dbContext.Software.AsNoTracking();
        public IQueryable<Syntax> Syntaxes => _dbContext.Syntaxes.AsNoTracking();
        public IQueryable<Tag> Tags => _dbContext.Tags.AsNoTracking();
    }
}