import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"
import ListDetails from "./ListDetails";

interface IFilterListsState {
    filterLists: IFilterListSummaryDto[];
    loading: boolean;
}

export class Home extends React.Component<RouteComponentProps<{}>, IFilterListsState> {
    constructor(props: any) {
        super(props);
        this.state = {
            filterLists: [],
            loading: true
        };
    }

    render() {
        const contents = this.state.loading
            ? <p>
                  <em>Loading...</em>
              </p>
            : Home.renderFilterListsTable(this.state.filterLists);
        return <div>
                   {contents}
               </div>;
    }

    componentDidMount() {
        fetch("https://filterlists.com/api/v1/lists")
            .then(response => response.json() as Promise<IFilterListSummaryDto[]>)
            .then(data => {
                this.setState({
                    filterLists: data,
                    loading: false
                });
            });
    }

    private static renderFilterListsTable(filterLists: IFilterListSummaryDto[]) {
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
                           sortMethod: (a: any, b: any) => a.toUpperCase() > b.toUpperCase() ? 1 : -1
                       },
                       {
                           Header: "Languages",
                           accessor: "languages",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id]
                               .map((e: any) => e.name.concat(e.iso6391)).join().toUpperCase()
                               .includes(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) => a.join().toUpperCase() > b.join().toUpperCase() ? 1 : -1,
                           Cell: (cell: any) => <div>{cell.value.map((e: any) => e.name).join(", ")}</div>,
                           style: { whiteSpace: "inherit" },
                           width: 100,
                           headerClassName: "hidden-xs",
                           className: "hidden-xs"
                       },
                       {
                           Header: "Details",
                           accessor: "id",
                           sortable: false,
                           expander: true,
                           Expander: ({ isExpanded, ...rest }) =>
                               <div>
                                   {isExpanded
                                       ? <button className="btn btn-primary btn-block active">Details</button>
                                       : <button className="btn btn-primary btn-block">Details</button>}
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
                           headerClassName: "hidden-xs",
                           className: "hidden-xs"
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

interface IFilterListSummaryDto {
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