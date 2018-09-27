import * as React from "react";
import { IColumnVisibility, ILanguage, IList, IMaintainer, ISoftware, ITag } from "../../interfaces";
import "../../../../utils/loader.css";
import ReactTable from "react-table";
import "react-table/react-table.css";
import "./listsTable.css";
import { DetailsButton, Languages, Name, Software, Tags, UpdatedDate } from "./columns";
import { IListDetails } from "../../components/detailsExpander";
import { DetailsExpander } from "../../components";

interface IProps {
    languages: ILanguage[];
    lists: IList[];
    maintainers: IMaintainer[];
    software: ISoftware[];
    tags: ITag[];
    columnVisibility: IColumnVisibility[];
    pageSize: number;
};

export const ListsTable = (props: IProps) =>
    props.languages.length > 0 && props.lists.length > 0 && props.software.length > 0 && props.tags.length > 0
    ? <ReactTable
          data={props.lists}
          defaultPageSize={props.pageSize}
          showPageSizeOptions={false}
          columns={[
              Name,
              Software(props.columnVisibility, props.software),
              Tags(props.columnVisibility, props.tags),
              Languages(props.columnVisibility, props.languages),
              UpdatedDate(props.columnVisibility),
              DetailsButton
          ]}
          defaultSorted={[{ id: "name" }]}
          SubComponent={(r: any) => <DetailsExpander list={mapListDetails(({
              list: r.original,
              languages: props.languages,
              maintainers: props.maintainers,
              tags: props.tags
          } as ICreateListDtoProps))}/>}
          className="-striped -highlight"/>
    : <div className="loader">Loading...</div>;

interface ICreateListDtoProps {
    list: IList;
    languages: ILanguage[];
    maintainers: IMaintainer[];
    tags: ITag[];
};

const mapListDetails = (props: ICreateListDtoProps): IListDetails =>
({
    id: props.list.id,
    chatUrl: props.list.chatUrl,
    description: props.list.description,
    descriptionSourceUrl: props.list.descriptionSourceUrl,
    discontinuedDate: props.list.discontinuedDate,
    donateUrl: props.list.donateUrl,
    emailAddress: props.list.emailAddress,
    forumUrl: props.list.forumUrl,
    homeUrl: props.list.homeUrl,
    issuesUrl: props.list.issuesUrl,
    languages: props.list.languageIds
                   ? props.languages.filter((l: ILanguage) => props.list.languageIds.indexOf(l.id) > -1)
                   : undefined,
    //license:,
    maintainers: props.list.maintainerIds
                     ? props.maintainers.filter((m: IMaintainer) => props.list.maintainerIds.indexOf(m.id) > -1)
                     : undefined,
    name: props.list.name,
    policyUrl: props.list.policyUrl,
    publishedDate: props.list.publishedDate,
    ruleCount: props.list.ruleCount,
    submissionUrl: props.list.submissionUrl,
    //syntax:,
    tags: props.list.tagIds ? props.tags.filter((t: ITag) => props.list.tagIds.indexOf(t.id) > -1) : undefined,
    updatedDate: props.list.updatedDate,
    viewUrl: props.list.viewUrl,
    viewUrlMirrors: props.list.viewUrlMirrors
} as IListDetails);