import * as React from "react";
import ReactTable from "react-table";
import "react-table/react-table.css";
import "../../../../utils/loader.css";
import { DetailsExpander } from "../../components";
import { IColumnVisibility } from "../../interfaces/IColumnVisibility";
import { ILicense } from "../../interfaces/ILicense";
import { IList } from "../../interfaces/IList";
import { IMaintainer } from "../../interfaces/IMaintainer";
import { ISoftware } from "../../interfaces/ISoftware";
import { ISyntax } from "../../interfaces/ISyntax";
import { ITag } from "../../interfaces/ITag";
import { Language } from "../../interfaces/Language";
import { IListDetails } from "../IListDetails";
import { DetailsButton, Languages, License, Maintainers, Name, Software, SubscribeButton, Tags } from "./columns";
import "./listsTable.css";

interface Props {
    languages: Language[];
    licenses: ILicense[];
    lists: IList[];
    maintainers: IMaintainer[];
    software: ISoftware[];
    syntaxes: ISyntax[];
    tags: ITag[];
    columnVisibility: IColumnVisibility[];
    pageSize: number;
};

export const ListsTable = (props: Props) =>
    props.languages.length > 0 && props.lists.length > 0 && props.software.length > 0 && props.tags.length > 0
        ? <ReactTable
            data={props.lists}
            defaultPageSize={props.pageSize}
            showPageSizeOptions={false}
            columns={[
                Name,
                Software(props.columnVisibility, props.software),
                Languages(props.columnVisibility, props.languages),
                Tags(props.columnVisibility, props.tags),
                License(props.columnVisibility, props.licenses),
                Maintainers(props.columnVisibility, props.maintainers),
                SubscribeButton(props.columnVisibility),
                DetailsButton
            ]}
            defaultSorted={[{ id: "name", desc: false }]}
            SubComponent={(r: any) =>
                <DetailsExpander columnVisibility={props.columnVisibility}
                    list={mapListDetails(({
                        list: r.original,
                        languages: props.languages,
                        licenses: props.licenses,
                        maintainers: props.maintainers,
                        syntaxes: props.syntaxes,
                        tags: props.tags
                    } as ICreateListDtoProps))}
                    software={props.software} />}
            className="-striped -highlight" />
        : <div className="loader">Loading...</div>;

interface ICreateListDtoProps {
    list: IList;
    languages: Language[];
    licenses: ILicense[];
    maintainers: IMaintainer[];
    syntaxes: ISyntax[];
    tags: ITag[];
};

const mapListDetails = (props: ICreateListDtoProps): IListDetails =>
    ({
        id: props.list.id,
        chatUrl: props.list.chatUrl,
        description: props.list.description,
        descriptionSourceUrl: props.list.descriptionSourceUrl,
        donateUrl: props.list.donateUrl,
        emailAddress: props.list.emailAddress,
        forumUrl: props.list.forumUrl,
        homeUrl: props.list.homeUrl,
        issuesUrl: props.list.issuesUrl,
        languages: props.list.languageIds
            ? props.languages.filter((l: Language) => props.list.languageIds.indexOf(l.id) > -1)
            : undefined,
        license: props.licenses.filter((l: ILicense) => props.list.licenseId === l.id)[0],
        maintainers: props.list.maintainerIds
            ? props.maintainers.filter((m: IMaintainer) => props.list.maintainerIds.indexOf(m.id) > -1)
            : undefined,
        name: props.list.name,
        policyUrl: props.list.policyUrl,
        publishedDate: props.list.publishedDate,
        submissionUrl: props.list.submissionUrl,
        syntax: props.syntaxes.filter((s: ISyntax) => props.list.syntaxId === s.id)[0],
        tags: props.list.tagIds ? props.tags.filter((t: ITag) => props.list.tagIds.indexOf(t.id) > -1) : undefined,
        viewUrl: props.list.viewUrl,
        viewUrlMirrors: props.list.viewUrlMirrors
    } as IListDetails);