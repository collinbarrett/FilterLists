import { ILicense } from "../interfaces/ILicense";
import { IMaintainer } from "../interfaces/IMaintainer";
import { ISyntax } from "../interfaces/ISyntax";
import { ITag } from "../interfaces/ITag";
import { Language } from "../interfaces/Language";

export interface IListDetails {
    id: number;
    chatUrl: string;
    description: string;
    descriptionSourceUrl: string;
    donateUrl: string;
    emailAddress: string;
    forumUrl: string;
    homeUrl: string;
    issuesUrl: string;
    languages: Language[];
    license: ILicense;
    maintainers: IMaintainer[];
    name: string;
    policyUrl: string;
    publishedDate: string;
    submissionUrl: string;
    syntax: ISyntax;
    tags: ITag[];
    viewUrl: string;
    viewUrlMirrors: string[];
};