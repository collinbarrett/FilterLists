using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Interfaces
{
    public interface IGet
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetById(int id);
    }
}