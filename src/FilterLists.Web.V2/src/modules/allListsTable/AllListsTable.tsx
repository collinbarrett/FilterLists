import { Table } from 'antd';
import * as React from "react";
import { List } from './List';

const columns = [
    {
        title: 'Name',
        dataIndex: 'name',
    }
];

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
        this.fetch();
    }

    fetch() {
        this.setState({ loading: true });
        fetch("/api/v1/lists")
            .then(response => response.json())
            .then(json => {
                this.setState({ data: json, loading: false });
            })
    };

    render() {
        return (
            <Table
                columns={columns}
                rowKey={record => record.id.toString()}
                dataSource={this.state.data}
                loading={this.state.loading}
            />
        );
    }
}