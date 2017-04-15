using System.Collections.Generic;
using FilterLists.Data.Models;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

//using JetBrains.Annotations;

namespace FilterLists.Services.Implementations
{
    //[UsedImplicitly]
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