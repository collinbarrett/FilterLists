using System.Linq;
using FilterLists.Models;

namespace FilterLists.Services
{
    public interface IListService
    {
        IQueryable<List> Lists { get; }
    }
}