using System.Collections.Generic;
using System.Linq;
using FilterLists.Data.Contexts;
using FilterLists.Data.Contracts.Repositories;
using FilterLists.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Data.Repositories
{
    public class ListRepository : IListRepository
    {
        private readonly DbContextOptions _options;

        public ListRepository(DbContextOptions options)
        {
            _options = options;
        }

        public IEnumerable<List> GetAll()
        {
            using (var context = new FilterListsDbContext(_options))
            {
                context.Database.OpenConnection();
                return context.List.AsEnumerable();
            }
        }
    }
}