using System;
using System.Collections.Generic;

namespace FilterLists.Services.FilterListService
{
    public class ListDetailsDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public ListLicenseDto License { get; set; }
        public IEnumerable<ListMaintainerDto> Maintainers { get; set; }
        public string Name { get; set; }
        public string PolicyUrl { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string SubmissionUrl { get; set; }
        public ListSyntaxDto Syntax { get; set; }
        public string ViewUrl { get; set; }
    }

    public class ListMaintainerDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
        public IEnumerable<MaintainerAdditionalListsDto> AdditionalLists { get; set; }
    }

    public class MaintainerAdditionalListsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ListLicenseDto
    {
        public string DescriptionUrl { get; set; }
        public string Name { get; set; }
    }

    public class ListSyntaxDto
    {
        public string DefinitionUrl { get; set; }
        public string Name { get; set; }
        public IEnumerable<SyntaxSupportedSoftwareDto> SupportedSoftware { get; set; }
    }

    public class SyntaxSupportedSoftwareDto
    {
        public string HomeUrl { get; set; }
        public string Name { get; set; }
    }
}