import { ILanguage, IMaintainer, ITag } from "../../interfaces";

export interface IListDetails {
    id: number;
    chatUrl: string;
    description: string;
    descriptionSourceUrl: string;
    discontinuedDate: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    languages: ILanguage[];
    license: IListLicense;
    maintainers: IMaintainer[];
    name: string;
    policyUrl: string;
    publishedDate: string;
    ruleCount: number;
    submissionUrl: string;
    syntax: IListSyntax;
    tags: ITag[];
    updatedDate: string;
    viewUrl: string;
    viewUrlMirrors: string[];
}

export interface IListLicense {
    descriptionUrl: string;
    name: string;
}

export interface IListSyntax {
    definitionUrl: string;
    name: string;
    supportedSoftware: ISyntaxSupportedSoftware[];
}

export interface ISyntaxSupportedSoftware {
    homeUrl: string;
    id: number;
    name: string;
}