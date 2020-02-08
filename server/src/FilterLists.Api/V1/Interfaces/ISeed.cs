using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Interfaces
{
    public interface ISeed
    {
        Task<IActionResult> Seed();
    }
}