using System.Linq;
using FilterLists.Data.Repositories;
using FilterLists.Models;

namespace FilterLists.Services
{
    public class ListService : IListService
    {
        private readonly IRepository<List> _listRepository;

        public ListService(IRepository<List> listRepository)
        {
            _listRepository = listRepository;
        }

        public IQueryable<List> Lists => (IQueryable<List>) _listRepository.GetAll();
    }
}