using System.Collections.Generic;
using FilterLists.Data.Models.Contracts;
using FilterLists.Data.Repositories.Contracts;
using FilterLists.Services.Contracts;

namespace FilterLists.Services.Implementations
{
    public class ListService : IListService
    {
        private readonly IListRepository listRepository;

        public ListService(IListRepository listRepository)
        {
            this.listRepository = listRepository;
        }

        public IEnumerable<IList> GetAll()
        {
            return listRepository.GetAll();
        }
    }
}