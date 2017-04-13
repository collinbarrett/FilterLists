using System.Collections.Generic;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class ListService : IListService
    {
        private readonly IListRepository _listRepository;

        public ListService(IListRepository listRepository)
        {
            _listRepository = listRepository;
        }

        public IEnumerable<List> GetAll()
        {
            return _listRepository.GetAll();
        }
    }
}