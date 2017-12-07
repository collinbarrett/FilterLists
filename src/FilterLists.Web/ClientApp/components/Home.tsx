import * as React from "react";
import { RouteComponentProps } from "react-router";
import "isomorphic-fetch";
import { Table } from 'antd';

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
                       {contents}
               </div>;
    }

    private static renderFilterListsTable(filterLists: IFilterList[]) {
        return <Table>
               </Table>;
    }
}