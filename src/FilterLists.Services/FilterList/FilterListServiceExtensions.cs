using System.Linq;
using System.Threading.Tasks;
using FilterLists.Services.FilterList.Models;

namespace FilterLists.Services.FilterList
{
    public static class FilterListServiceExtensions
    {
        public static async Task<ListDetails> FilterParentListFromMaintainerAdditionalLists(
            this Task<ListDetails> listDetailsDtos)
        {
            foreach (var maintainer in listDetailsDtos.Result.Maintainers)
                maintainer.AdditionalLists = maintainer
                                             .AdditionalLists.Where(additionalList =>
                                                 additionalList.Id != listDetailsDtos.Result.Id)
                                             .ToList();
            return await listDetailsDtos;
        }
    }
}