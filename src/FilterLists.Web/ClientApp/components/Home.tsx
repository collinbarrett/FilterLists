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
    pageSize: number;
}

export class Home extends React.Component<RouteComponentProps<{}>, IHomeState> {
    constructor(props: any) {
        super(props);
        this.state = {
            lists: [],
            loadingLists: true,
            ruleCount: 0,
            loadingRuleCount: true,
            pageSize: 20
        };
        this.updatePageSize = this.updatePageSize.bind(this);
    }

    render() {
        const contents = this.state.loadingLists || this.state.loadingRuleCount
            ? <p>
                  <em>Loading...</em>
              </p>
            : <div>
                  {Home.renderTagline(this.state)}
                  {Home.renderFilterListsTable(this.state)}
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
    }

    updatePageSize() {
        this.setState({
            pageSize: Math.max(Math.floor((window.innerHeight - 361) / 52), 5)
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
                           Cell: (cell: any) => <h2 className="mb-0">{cell.value}</h2>
                       },
                       {
                           Header: "Tags",
                           accessor: "tags",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id].map((e: any) => e.name).join()
                               .toUpperCase().includes(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) => a.join().toUpperCase() > b.join().toUpperCase() ? 1 : -1,
                           Cell: (cell: any) => <div>{cell.value.map(
                               (e: any) => <span className="badge" style={{
                                   backgroundColor: `#${e.colorHex}`,
                                   color: ListDetails.getContrast(`${e.colorHex}`)
                               }} title={e.description}>{e.name}</span>)}</div>,
                           width: 100,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block"
                       },
                       {
                           Header: "Langs.",
                           accessor: "languages",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id]
                               .map((e: any) => e.name.concat(e.iso6391)).join().toUpperCase()
                               .includes(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) => a.join().toUpperCase() > b.join().toUpperCase() ? 1 : -1,
                           Cell: (cell: any) =>
                               <div>{cell.value.map((e: any) => e.iso6391).join(", ")}</div>,
                           style: { whiteSpace: "inherit" },
                           width: 60,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block"
                       },
                       //{
                       //    Header: "Updated",
                       //    accessor: "updatedDate",
                       //    filterable: true,
                       //    filterMethod: (filter: any, row: any) => row[filter.id].includes(filter.value),
                       //    sortMethod: (a: any, b: any) => moment(a).isValid()
                       //        ? (moment(b).isValid() ? (moment(a).isBefore(b) ? -1 : 1) : 1)
                       //        : -1,
                       //    Cell: (cell: any) => <div>{moment(cell.value).isValid()
                       //        ? moment(cell.value).format("l")
                       //        : "N/A"}</div>,
                       //    style: { whiteSpace: "inherit" },
                       //    width: 100,
                       //    headerClassName: "d-none d-md-block",
                       //    className: "d-none d-md-block"
                       //},
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
                           width: 105
                       },
                       {
                           Header: "Subscribe",
                           accessor: "viewUrl",
                           sortable: false,
                           Cell: (cell: any) => <SubscribeUrl url={cell.value} name={cell.row.name}/>,
                           style: { textAlign: "center" },
                           width: 105,
                           headerClassName: "d-none d-md-block",
                           className: "d-none d-md-block"
                       }
                   ]}
                   SubComponent={(row: any) => {
                       return (
                           <ListDetails listId={row.original.id}/>
                       );
                   }}
                   className="-striped -highlight"/>;
    }
}

interface IListDto {
    id: number;
    name: string;
    languages: IListLanguageDto[];
    tags: IListTagDto[];
    updatedDate: string;
    viewUrl: string;
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

function SubscribeUrl(props: any) {
    return props.url.indexOf("https://") === -1
        ? SubscribeUrlNotSecure()
        : props.url.indexOf("web.archive.org") === -1
            ? SubscribeUrlPrimary()
            : SubscribeUrlWayback();

    function SubscribeUrlPrimary() {
        return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
                  className="btn btn-primary btn-block"
                  title={`Subscribe to list with browser extension supporting \"abp:\" protocol (e.g. uBlock Origin, AdBlock Plus).`}>
                   Subscribe
               </a>;
    }

    function SubscribeUrlWayback() {
        return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
                  className="btn btn-secondary btn-block"
                  title={`Archive.org Mirror (Original Offline) - Subscribe to list with browser extension supporting \"abp:\" protocol (e.g. uBlock Origin, AdBlock Plus).`}>
                   Subscribe
               </a>;
    }

    function SubscribeUrlNotSecure() {
        return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
                  className="btn btn-danger btn-block"
                  title={`Not Secure - Subscribe to list with browser extension supporting \"abp:\" protocol (e.g. uBlock Origin, AdBlock Plus).`}>
                   Subscribe
               </a>;
    }
};