import { Table } from 'antd';
import * as React from "react";

const columns = [
    {
        title: 'Name',
        dataIndex: 'name',
        sorter: true,
        render: (name: { first: any; last: any; }) => `${name.first} ${name.last}`,
        width: '20%',
    },
    {
        title: 'Gender',
        dataIndex: 'gender',
        filters: [{ text: 'Male', value: 'male' }, { text: 'Female', value: 'female' }],
        width: '20%',
    },
    {
        title: 'Email',
        dataIndex: 'email',
    },
];

interface State {
    data: [];
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

    fetch = () => {
        this.setState({ loading: true });
        fetch("https://randomuser.me/api")
            .then(response => response.json())
            .then(json => {
                this.setState({ data: json.results });
                this.setState({ loading: false })
            })
    };

    render() {
        return (
            <Table
                columns={columns}
                dataSource={this.state.data}
                loading={this.state.loading}
            />
        );
    }
}