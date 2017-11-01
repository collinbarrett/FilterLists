import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import darkBaseTheme from "material-ui/styles/baseThemes/darkBaseTheme";
import MuiThemeProvider from "material-ui/styles/MuiThemeProvider";
import getMuiTheme from "material-ui/styles/getMuiTheme";
import {
    Table,
    TableBody,
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
                   <MuiThemeProvider muiTheme={getMuiTheme(darkBaseTheme)}>
                       {contents}
                   </MuiThemeProvider>
               </div>;
    }

    private static renderFilterListsTable(filterLists: IFilterList[]) {
        return <Table>
                   <TableBody>
                       {filterLists.map(filterList =>
                           <TableRow key={filterList.id}>
                               <TableRowColumn>
                                   <h2>{filterList.name}</h2>{filterList.description}
                               </TableRowColumn>
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