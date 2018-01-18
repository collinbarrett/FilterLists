import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import MuiThemeProvider from "material-ui/styles/MuiThemeProvider";
import {
    Table,
    TableHead,
    TableBody,
    TableRow,
    TableCell,
    } from "material-ui";

interface IFilterListsState {
    filterLists: IFilterList[];
    loading: boolean;
}

interface IFilterList {
    id: number;
    name: string;
    description: string;
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
                   <MuiThemeProvider>
                       {contents}
                   </MuiThemeProvider>
               </div>;
    }

    private static renderFilterListsTable(filterLists: IFilterList[]) {
        return <Table>
                   <TableHead>
                       <TableRow>
                           <TableCell>List</TableCell>
                       </TableRow>
                   </TableHead>
                   <TableBody>
                       {filterLists.map(filterList =>
                           <TableRow key={filterList.id}>
                                <TableCell><h2>{filterList.name}</h2>{filterList.description}</TableCell>
                           </TableRow>
                       )}
                   </TableBody>
               </Table>;
    }
}