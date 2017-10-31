import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";

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
        return <table className="table">
                   <thead>
                   <tr>
                       <th>Name</th>
                       <th>Description</th>
                   </tr>
                   </thead>
                   <tbody>
                   {filterLists.map(filterList =>
                       <tr key={filterList.id}>
                           <td>{filterList.name}</td>
                           <td>{filterList.description}</td>
                       </tr>
                   )}
                   </tbody>
               </table>;
    }
}

interface IFilterList {
    id: number;
    name: string;
    description: string;
}