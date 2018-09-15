import * as React from "react";
import { IListDto } from "../../IListDto";
import { ISoftwareDto } from "../../ISoftwareDto";
import { ILanguageDto } from "../../ILanguageDto";
import ReactTable from "react-table"
import "react-table/react-table.css"
import "./listsTable.css";
import * as moment from "moment";
import { SoftwareIcon } from "./SoftwareIcon";
import { getContrast } from "../../../../utils/GetContrast";
import { DetailsExpander } from "../../components";

export interface IColumnVisibility {
    column: string;
    visible: boolean;
}

interface IProps {
    lists: IListDto[];
    software: ISoftwareDto[];
    languages: ILanguageDto[];
    columnVisibility: IColumnVisibility[];
    pageSize: number;
}

export const ListsTable = (props: IProps) => {
    return <ReactTable
               data={props.lists}
               key={props.pageSize}
               defaultPageSize={props.pageSize}
               showPageSizeOptions={false}
               columns={[
                   {
                       Header: "Name",
                       accessor: "name",
                       filterable: true,
                       filterMethod: (f: any, r: any) =>
                           r[f.id].toUpperCase().includes(f.value.toUpperCase()),
                       sortMethod: (a: any, b: any) => a.toUpperCase() > b.toUpperCase() ? 1 : -1,
                       Cell: (c: any) => <h2 className="mb-0">{c.value}</h2>
                   },
                   {
                       Header: "Software",
                       accessor: "softwareIds",
                       filterable: true,
                       filterMethod: (f: any, r: any) =>
                           f.value === "any" || r[f.id].join(",").split(",").includes(f.value),
                       Filter: ({ filter, onChange }) =>
                           <select
                               onChange={(event: any) => onChange(event.target.value)}
                               style={{ width: "100%" }}
                               value={filter ? filter.value : "any"}>
                               <option value="any">Any</option>
                               {props.software.map((s: any, i) => <option value={s.id} key={i}>{s.name}</option>)}
                           </select>,
                       sortable: false,
                       Cell: (c: any) => c.value.map((s: number, i: any) => <SoftwareIcon id={s} key={i}/>),
                       width: 150,
                       headerClassName: "d-none d-md-block",
                       className: "d-none d-md-block",
                       show: props.columnVisibility.filter(
                           (c: IColumnVisibility) => { return c.column === "Software"; })[0].visible
                   },
                   {
                       Header: "Tags",
                       accessor: "tags",
                       filterable: true,
                       filterMethod: (f: any, r: any) =>
                           r[f.id].map((e: any) => e.name).join().toUpperCase().includes(f.value.toUpperCase()),
                       sortable: false,
                       Cell: (c: any) =>
                           <div className="fl-tag-container">
                               {c.value.map((e: any, i: any) =>
                                   <span className="badge"
                                         style={{
                                             backgroundColor: `#${e.colorHex}`,
                                             color: getContrast(`${e.colorHex}`)
                                         }}
                                         title={e.description}
                                         key={i}>
                                       {e.name}
                                   </span>)}
                           </div>,
                       width: 212,
                       headerClassName: "d-none d-md-block",
                       className: "d-none d-md-block",
                       show: props.columnVisibility.filter(
                           (c: IColumnVisibility) => { return c.column === "Tags"; })[0].visible
                   },
                   {
                       Header: "Languages",
                       accessor: "languages",
                       filterable: true,
                       filterMethod: (f: any, r: any) =>
                           f.value === "any" || r[f.id].map((x: any) => x.iso6391).includes(f.value),
                       Filter: ({ filter, onChange }) =>
                           <select
                               onChange={(event: any) => onChange(event.target.value)}
                               style={{ width: "100%" }}
                               value={filter ? filter.value : "any"}>
                               <option value="any">Any</option>
                               {props.languages.map((l: any, i) =>
                                   <option value={l.iso6391} key={i}>{l.name}</option>)}
                           </select>,
                       sortable: false,
                       Cell: (c: any) =>
                           <div className="fl-tag-container">
                               {c.value.map((e: any, i: any) =>
                                   <span className="badge badge-secondary"
                                         title={e.name}
                                         key={i}>
                                       {e.iso6391}
                                   </span>)}
                           </div>,
                       style: { whiteSpace: "inherit" },
                       width: 95,
                       headerClassName: "d-none d-md-block",
                       className: "d-none d-md-block",
                       show: props.columnVisibility.filter(
                           (c: IColumnVisibility) => { return c.column === "Languages"; })[0].visible
                   },
                   {
                       Header: "Updated",
                       accessor: "updatedDate",
                       filterable: true,
                       filterMethod: (f: any, r: any) => r[f.id].includes(f.value),
                       sortMethod: (a: any, b: any) =>
                           moment(a).isValid() ? (moment(b).isValid() ? (moment(a).isBefore(b) ? -1 : 1) : 1) : -1,
                       Cell: (c: any) =>
                           <div>
                               {moment(c.value).isValid() ? moment(c.value).format("l") : "N/A"}
                           </div>,
                       style: { whiteSpace: "inherit" },
                       width: 100,
                       headerClassName: "d-none d-md-block",
                       className: "d-none d-md-block",
                       show: props.columnVisibility.filter(
                           (c: IColumnVisibility) => { return c.column === "Updated Date"; })[0].visible
                   },
                   {
                       Header: "Details",
                       accessor: "id",
                       sortable: false,
                       expander: true,
                       Expander: ({ isExpanded, row }) =>
                           <div>
                               {isExpanded
                                    ? <button className="btn btn-primary btn-block active"
                                              title={`Collapse details about ${row.name}.`}>
                                          Details
                                      </button>
                                    : <button className="btn btn-primary btn-block"
                                              title={`Learn more about ${row.name}.`}>
                                          Details
                                      </button>}
                           </div>,
                       style: { textAlign: "center" },
                       width: 90
                   }
               ]}
               SubComponent={(r: any) => <DetailsExpander listId={r.original.id}/>}
               className="-striped -highlight"/>;
};