import { Table } from 'antd';
import * as React from "react";
import { nameof } from '../../utils';
import { List } from './List';

interface State {
    data: List[];
    loading: boolean;
}

export class AllListsTable extends React.Component<{}, State> {
    constructor(props: any) {
        super(props);
        this.state = {
            data: [],
            loading: false,
        };
    }

    componentDidMount() {
        this.setState({ loading: true });
        fetch("/api/v1/lists")
            .then(response => response.json())
            .then(json => { this.setState({ data: json, loading: false }); })
    }

    render() {
        return (
            <Table<List> dataSource={this.state.data} rowKey={record => record.id.toString()} loading={this.state.loading}>
                <Table.Column<List> title="Name" dataIndex={nameof<List>("name")} />
                <Table.Column<List> title="Description" dataIndex={nameof<List>("description")} />
            </Table>
        );
    }
}