import { Table } from 'antd';
import * as React from "react";
import { columnProps } from './columnProps';
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
                size="small"
                scroll={{ x: 1500 }}
                columns={columnProps}
                rowKey={record => record.id.toString()}
                dataSource={this.state.data}
                loading={this.state.loading}
            />
        );
    }
}