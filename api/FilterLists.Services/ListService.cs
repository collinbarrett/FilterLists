using System.Collections.Generic;
using FilterLists.Data.Contracts.Repositories;
using FilterLists.Models;

namespace FilterLists.Services
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