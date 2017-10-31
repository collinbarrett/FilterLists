import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import {
    Table,
    TableBody,
    TableHeader,
    TableHeaderColumn,
    TableRow,
    TableRowColumn,
    } from "material-ui";

interface IFilterListsState {
    filterLists: IFilterList[];
    loading: boolean;
}

export class Home extends React.Component<RouteComponentProps<{}>, IFilterListsState> {
    constructor() {
        super();
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
        return <Table>
                   <TableHeader>
                       <TableRow>
                           <TableHeaderColumn>Name</TableHeaderColumn>
                           <TableHeaderColumn>Description</TableHeaderColumn>
                       </TableRow>
                   </TableHeader>
                   <TableBody>
                       {filterLists.map(filterList =>
                           <TableRow key={filterList.id}>
                               <TableRowColumn>{filterList.name}</TableRowColumn>
                               <TableRowColumn>{filterList.description}</TableRowColumn>
                           </TableRow>
                       )}
                   </TableBody>
               </Table>;
    }
}

interface IFilterList {
    id: number;
    name: string;
    description: string;
}