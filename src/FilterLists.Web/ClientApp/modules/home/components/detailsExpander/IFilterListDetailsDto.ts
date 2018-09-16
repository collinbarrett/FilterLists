export interface IFilterListDetailsDto {
    chatUrl: string;
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    languages: string[];
    license: IListLicenseDto;
    maintainers: IListMaintainerDto[];
    name: string;
    policyUrl: string;
    publishedDate: string;
    ruleCount: number;
    submissionUrl: string;
    syntax: IListSyntaxDto;
    tags: IListTagDto[];
    updatedDate: string;
    viewUrl: string;
    viewUrlMirror1: string;
    viewUrlMirror2: string;
}

export interface IListLicenseDto {
    descriptionUrl: string;
    name: string;
}

export interface IListMaintainerDto {
    id: number;
    emailAddress: string;
    homeUrl: string;
    name: string;
    twitterHandle: string;
    additionalLists: IMaintainerAdditionalListDto[];
}

export interface IListSyntaxDto {
    definitionUrl: string;
    name: string;
    supportedSoftware: ISyntaxSupportedSoftwareDto[];
}

export interface IListTagDto {
    name: string;
    colorHex: string;
    description: string;
}

export interface IMaintainerAdditionalListDto {
    id: number;
    name: string;
}

export interface ISyntaxSupportedSoftwareDto {
    homeUrl: string;
    name: string;
}