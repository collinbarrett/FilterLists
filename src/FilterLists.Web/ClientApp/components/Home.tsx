import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"
import ListDetails from "./ListDetails";

interface IHomeState {
    lists: IListDto[];
    loadingLists: boolean;
    ruleCount: number;
    loadingRuleCount: boolean;
}

export class Home extends React.Component<RouteComponentProps<{}>, IHomeState> {
    constructor(props: any) {
        super(props);
        this.state = {
            lists: [],
            loadingLists: true,
            ruleCount: 0,
            loadingRuleCount: true
        };
    }

    render() {
        const contents = this.state.loadingLists || this.state.loadingRuleCount
            ? <p>
                  <em>Loading...</em>
              </p>
            : <div>
                  {Home.renderTagline(this.state)}
                  {Home.renderFilterListsTable(this.state.lists)}
              </div>;
        return <div>
                   {contents}
               </div>;
    }

    componentDidMount() {
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

    private static renderTagline(state: IHomeState) {
        return <p className="ml-2 mr-2">
                   The independent, comprehensive directory of <strong>{this.insertCommasInNumber(state.ruleCount)
                   }</strong> unique rules across <strong>{state.lists.length
                   }</strong> filter and host lists for advertisements, trackers, malware, and annoyances.
               </p>;
    }

    //https://stackoverflow.com/a/2901298/2343739
    private static insertCommasInNumber(num: number) {
        return num.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    }

    private static renderFilterListsTable(filterLists: IListDto[]) {
        return <ReactTable
                   data={filterLists}
                   defaultSorted={[{ id: "name" }]}
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
                           Header: "Langs.",
                           accessor: "languages",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id]
                               .map((e: any) => e.name.concat(e.iso6391)).join().toUpperCase()
                               .includes(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) => a.join().toUpperCase() > b.join().toUpperCase() ? 1 : -1,
                           Cell: (cell: any) => <div>{cell.value.map((e: any) => e.iso6391).join(", ")}</div>,
                           style: { whiteSpace: "inherit" },
                           width: 60,
                           headerClassName: "d-none d-sm-block",
                           className: "d-none d-sm-block"
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
                           width: 100
                       },
                       {
                           Header: "Subscribe",
                           accessor: "viewUrl",
                           sortable: false,
                           Cell: (cell: any) => <SubscribeUrl url={cell.value} name={cell.row.name}/>,
                           style: { textAlign: "center" },
                           width: 100,
                           headerClassName: "d-none d-sm-block",
                           className: "d-none d-sm-block"
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
    viewUrl: string;
}

interface IListLanguageDto {
    name: string;
    iso6391: string;
}

function SubscribeUrl(props: any) {
    return <a href={`abp:subscribe?location=${encodeURIComponent(props.url)}&amp;title=${encodeURIComponent(props.name)}`}
              className="btn btn-primary btn-block"
              title={"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
               Subscribe
           </a>;
}