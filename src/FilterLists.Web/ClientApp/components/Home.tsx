import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import ReactTable from "react-table"
import "react-table/react-table.css"
import ListDetailsModal from "./ListDetailsModal";

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

    private static renderFilterListsTable(filterLists: IFilterList[]) {
        return <ReactTable
                   data={filterLists}
                   columns={[
                       {
                           Header: "Id (temp)",
                           accessor: "id"
                       },
                       {
                           Header: "Name",
                           accessor: "name"
                       },
                       {
                           Header: "Details",
                           accessor: "id",
                           Cell: (d: any) => <ListDetailsModal listId={d.value}/>,
                           style: { textAlign: "center" },
                           width: 100
                       }
                   ]}/>;
    }
}

interface IFilterList {
    id: number;
    name: string;
}