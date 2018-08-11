using System.Linq;
using System.Threading.Tasks;
using FilterLists.Services.FilterList.Models;

namespace FilterLists.Services.FilterList
{
    public static class FilterListServiceExtensions
    {
        public static async Task<ListDetailsDto> FilterParentListFromMaintainerAdditionalLists(
            this Task<ListDetailsDto> listDetailsDtos)
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