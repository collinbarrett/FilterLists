import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"
import ListDetailsModal from "./ListDetailsModal";

interface IFilterListsState {
    filterLists: IFilterListSummaryDto[];
    loading: boolean;
}

export class Home extends React.Component<RouteComponentProps<{}>, IFilterListsState> {
    constructor(props: any) {
        super(props);
        this.state = { filterLists: [], loading: true };
        fetch("https://api.filterlists.com/v1/lists")
            .then(response => response.json() as Promise<IFilterListSummaryDto[]>)
            .then(data => { this.setState({ filterLists: data, loading: false }); });
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

    private static renderFilterListsTable(filterLists: IFilterListSummaryDto[]) {
        return <ReactTable
                   data={filterLists}
                   defaultSorted={[{id: "name"}]}
                   columns={[
                       {
                           Header: "Name",
                           accessor: "name",
                           filterable: true,
                           filterMethod: (filter: any, row: any) => row[filter.id].toUpperCase().startsWith(filter.value.toUpperCase()),
                           sortMethod: (a: any, b: any) =>  a.toUpperCase() > b.toUpperCase() ? 1 : -1
                       },
                       {
                           Header: "Details",
                           sortable: false,
                           Cell: (rowInfo: any) => <ListDetailsModal listId={rowInfo.original.id}/>,
                           style: { textAlign: "center" },
                           width: 100
                       },
                       {
                           Header: "Subscribe",
                           sortable: false,
                           Cell: (rowInfo: any) => <a
                               href={`abp:subscribe?location=${encodeURIComponent(rowInfo.row.viewUrl)}&amp;title=${encodeURIComponent(rowInfo.row.name)}`}
                               className="btn btn-primary btn-block"
                               title={"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
                               Subscribe</a>,
                           style: { textAlign: "center" },
                           width: 100
                       }
                   ]}/>;
    }
}

interface IFilterListSummaryDto {
    id: number;
    name: string;
    viewUrl: string;
}