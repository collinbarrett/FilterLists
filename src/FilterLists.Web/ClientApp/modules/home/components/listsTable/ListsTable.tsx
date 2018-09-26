import * as React from "react";
import { IColumnVisibility, ILanguage, IList, ISoftware, ITag } from "../../interfaces";
import "../../../../utils/loader.css";
import ReactTable from "react-table"
import "react-table/react-table.css"
import "./listsTable.css";
import { DetailsButton, Languages, Name, Software, Tags, UpdatedDate } from "./columns";
import { DetailsExpander } from "../../components";

interface IProps {
    languages: ILanguage[];
    lists: IList[];
    software: ISoftware[];
    tags: ITag[];
    columnVisibility: IColumnVisibility[];
    pageSize: number;
};

export const ListsTable = (props: IProps) =>
    props.lists.length > 0 && props.languages.length > 0 && props.software.length > 0
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
          SubComponent={(r: any) => <DetailsExpander listId={r.original.id}/>}
          className="-striped -highlight"/>
    : <div className="loader">Loading...</div>;