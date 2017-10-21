using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;
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

        public IEnumerable<IList> GetAll()
        {
            return _listRepository.GetAll();
        }
    }
}