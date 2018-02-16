import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"

interface IFilterListsState {
    filterLists: IFilterList[];
    loading: boolean;
}

export class Home extends React.Component<RouteComponentProps<{}>, IFilterListsState> {
    constructor(props: any) {
        super(props);
        this.state = { filterLists: [], loading: true };

        fetch("https://api.filterlists.com/v1/lists")
            .then(response => response.json() as Promise<IFilterList[]>)
            .then(data => {
                this.setState({ filterLists: data, loading: false });
            });
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

    private static renderFilterListsTable(filterLists: IFilterList[]) {
        return <ReactTable
                   data={filterLists}
                   columns={[
                       {
                           Header: "Name",
                           accessor: "name"
                       },
                       {
                           Header: "View",
                           accessor: "viewUrl",
                           Cell: (d: any) => <a href={d.value}
                                                title={"View the raw list. Many are quite large, so be cautious if on metered bandwidth."}>
                                                 View
                                             </a>,
                           style: { textAlign: "center" }
                       },
                       {
                           Header: "Subscribe",
                           accessor: "viewUrl",
                           Cell: (d: any) => <a href={`abp:subscribe?location=${encodeURIComponent(d.value)
                                                }&amp;title=${encodeURIComponent(d.row.name)}`}
                                                title={"Subscribe to list with browser extension supporting \"abp:\" protcool (e.g. uBlock Origin, AdBlock Plus)."}>
                                                Subscribe
                                             </a>,
                           style: { textAlign: "center" }
                       }
                   ]}
                   SubComponent={(row: any) => {
                       return (
                           <div style={{ padding: "20px" }}>
                               <em>
                                   {row.original.description}
                               </em>
                           </div>
                       );
                   }}/>;
    }
}

interface IFilterList {
    id: number;
    name: string;
    description: string;
    viewUrl: string;
}