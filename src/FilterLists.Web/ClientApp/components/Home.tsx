import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"
import ListDetails from "./ListDetails";
import * as moment from "moment";

interface IHomeState {
    lists: IListDto[];
    loadingLists: boolean;
    ruleCount: number;
    loadingRuleCount: boolean;
    software: ISoftwareDto[];
    loadingSoftware: boolean;
    languages: ILanguageDto[];
    loadingLanguages: boolean;
    columnVisibility: IColumnVisibility[];
    pageSize: number;
}

const columnVisibilityDefaults = [
    { column: "Name", visible: true },
    { column: "Software", visible: true },
    { column: "Tags", visible: true },
    { column: "Languages", visible: true },
    { column: "Updated Date", visible: true },
    { column: "Details", visible: true }
];

export class Home extends React.Component<RouteComponentProps<{}>, IHomeState> {
    constructor(props: any) {
        super(props);
        this.state = {
            lists: [],
            loadingLists: true,
            ruleCount: 0,
            loadingRuleCount: true,
            software: [],
            loadingSoftware: true,
            languages: [],
            loadingLanguages: true,
            columnVisibility: columnVisibilityDefaults,
            pageSize: 20
        };
        this.updatePageSize = this.updatePageSize.bind(this);
    }

    render() {
        const contents = this.state.loadingLists ||
            this.state.loadingRuleCount ||
            this.state.loadingSoftware ||
            this.state.loadingLanguages
            ? <p>
                  <em>Loading...</em>
              </p>
            : <div>
                  {Home.renderTagline(this.state)}
                  {Home.renderFilterListsTable(this.state)}
                  {this.renderColumnVisibilityCheckboxes()}
              </div>;
        return <div>
                   {contents}
               </div>;
    }

    componentDidMount() {
        this.updatePageSize();
        fetch("https://filterlists.com/api/v1/lists")
            .then(response => response.json() as Promise<IListDto[]>)
            .then(data => {
                this.setState({
                    lists: data,
                    loadingLists: false
                });
            });
        fetch("https://filterlists.com/api/v1/rules")
            .then(response => response.json() as Promise<number>)
            .then(data => {
                this.setState({
                    ruleCount: data,
                    loadingRuleCount: false
                });
            });
        fetch("https://filterlists.com/api/v1/software")
            .then(response => response.json() as Promise<ISoftwareDto[]>)
            .then(data => {
                this.setState({
                    software: data,
                    loadingSoftware: false
                });
            });
        fetch("https://filterlists.com/api/v1/languages")
            .then(response => response.json() as Promise<ILanguageDto[]>)
            .then(data => {
                this.setState({
                    languages: data,
                    loadingLanguages: false
                });
            });
    }

    updatePageSize() {
        this.setState({
            pageSize: Math.max(Math.floor((window.innerHeight - 386) / 52), 5)
        });
    }

    private static renderTagline(state: IHomeState) {
        return <p className="ml-2 mr-2">
                   The independent, comprehensive directory of <strong>{state.ruleCount.toLocaleString()
                   }</strong> unique rules across <strong>{state.lists.length
                   }</strong> filter and host lists for advertisements, trackers, malware, and annoyances.
               </p>;
    }

    private static renderFilterListsTable(state: IHomeState) {
        return <ReactTable
                   data={state.lists}
                   key={state.pageSize}
                   defaultPageSize={state.pageSize}
                   showPageSizeOptions={false}
                   columns={[
                       {
                           Header: "Name",
                           accessor: "name",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id].toUpperCase()
                               .includes(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) => a.toUpperCase() > b.toUpperCase() ? 1 : -1,
                           Cell: (cell: any) => <h2 className="mb-0">{cell.value}</h2>,
                           style: { overflow: "visible" },
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Name";
                           })[0].visible
                       },
                       {
                           Header: "Software Support",
                           accessor: "softwareIds",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => {
                               if (filter.value === "any") {
                                   return true;
                               }
                               return row[filter.id].join(",").split(",").includes(filter.value);
                           },
                           Filter: ({ filter, onChange }) =>
                               <select
                                   onChange={(event: any) => onChange(event.target.value)}
                                   style={{ width: "100%" }}
                                   value={filter ? filter.value : "any"}>
                                   <option value="any">Any</option>
                                   {state.software.map((e: any) => <option value={e.id}>{e.name}</option>)}
                               </select>,
                           sortable: false,
                           Cell: () => null,
                           width: 250,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block",
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Software";
                           })[0].visible
                       },
                       {
                           Header: "Tags",
                           accessor: "tags",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id].map((e: any) => e.name).join()
                               .toUpperCase().includes(filter.value.toUpperCase()),
                           sortable: false,
                           Cell: (cell: any) => <div className="fl-tag-container">{cell.value.map(
                               (e: any) => <span className="badge" style={{
                                   backgroundColor: `#${e.colorHex}`,
                                   color: ListDetails.getContrast(`${e.colorHex}`)
                               }} title={e.description}>{e.name}</span>)}</div>,
                           width: 200,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block",
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Tags";
                           })[0].visible
                       },
                       {
                           Header: "Languages",
                           accessor: "languages",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => {
                               if (filter.value === "any") {
                                   return true;
                               }
                               return row[filter.id].map((x: any) => x.iso6391).includes(filter.value);
                           },
                           Filter: ({ filter, onChange }) =>
                               <select
                                   onChange={(event: any) => onChange(event.target.value)}
                                   style={{ width: "100%" }}
                                   value={filter ? filter.value : "any"}>
                                   <option value="any">Any</option>
                                   {state.languages.map((e: any) => <option value={e.iso6391}>{e.name}</option>)}
                               </select>,
                           sortable: false,
                           Cell: (cell: any) => <div className="fl-tag-container">{cell.value.map(
                               (e: any) => <span className="badge badge-secondary" title={e.name}>{e.iso6391}</span>)
                           }</div>,
                           style: { whiteSpace: "inherit" },
                           width: 100,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block",
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Languages";
                           })[0].visible
                       },
                       {
                           Header: "Updated",
                           accessor: "updatedDate",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id].includes(filter.value),
                           sortMethod: (a: any, b: any) => moment(a).isValid()
                               ? (moment(b).isValid() ? (moment(a).isBefore(b) ? -1 : 1) : 1)
                               : -1,
                           Cell: (cell: any) => <div>{moment(cell.value).isValid()
                               ? moment(cell.value).format("l")
                               : "N/A"}</div>,
                           style: { whiteSpace: "inherit" },
                           width: 100,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block",
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Updated Date";
                           })[0].visible
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
                           width: 90,
                           show: state.columnVisibility.filter((c: IColumnVisibility) => {
                               return c.column === "Details";
                           })[0].visible
                       }
                   ]}
                   SubComponent={(row: any) => {
                       return (
                           <ListDetails listId={row.original.id}/>
                       );
                   }}
                   className="-striped -highlight"/>;
    }

    private renderColumnVisibilityCheckboxes() {
        return <div className="d-none d-md-block text-right">
                   Visible:&nbsp;&nbsp;{this.state.columnVisibility.map((c: IColumnVisibility) => this.renderColumnVisibilityCheckbox(c))}
               </div>;
    };

    private renderColumnVisibilityCheckbox(props: IColumnVisibility) {
        return <div className="form-check form-check-inline">
                   <input className="form-check-input" type="checkbox"id={`checkbox${props.column.replace(/\s+/g, "")}`} defaultChecked={props.visible} onChange={() => this.checkColumn(props)}/>
                   <label className="form-check-label" htmlFor={`checkbox${props.column.replace(/\s+/g, "")}`}>{props.column}</label>
               </div>;
    }

    private checkColumn(props: IColumnVisibility) {
        const columnVisibility = this.state.columnVisibility;
        const index = this.findWithAttr(columnVisibility, "column", props.column);
        columnVisibility[index].visible = !columnVisibility[index].visible;
        this.forceUpdate();
    }

    private findWithAttr(array: any, attr: any, value: any) {
        for (let i = 0; i < array.length; i += 1) {
            if (array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}

interface ISoftwareDto {
    id: number;
    name: string;
}

interface ILanguageDto {
    iso6391: string;
    name: string;
}

interface IListDto {
    id: number;
    name: string;
    languages: IListLanguageDto[];
    softwareIds: number[];
    tags: IListTagDto[];
    updatedDate: string;
}

interface IListLanguageDto {
    name: string;
    iso6391: string;
}

interface IListTagDto {
    name: string;
    colorHex: string;
    description: string;
}

interface IColumnVisibility {
    column: string;
    visible: boolean;
}