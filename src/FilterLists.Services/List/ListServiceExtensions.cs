using System.Linq;
using System.Threading.Tasks;
using FilterLists.Services.List.Models;

namespace FilterLists.Services.List
{
    public static class ListServiceExtensions
    {
        public static async Task<ListDetails> FilterParentListFromMaintainerAdditionalLists(
            this Task<ListDetails> listDetailsDtos)
        {
            foreach (var maintainer in listDetailsDtos.Result.Maintainers)
                maintainer.AdditionalLists = maintainer.AdditionalLists
                                                       .Where(a => a.Id != listDetailsDtos.Result.Id)
                                                       .ToList();
            return await listDetailsDtos;
        }
    }
}