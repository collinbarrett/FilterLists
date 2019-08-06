import { Table } from 'antd';
import * as React from "react";
import { SubscribeButton } from '../../shared/';
import { nameof } from '../../utils';
import { List } from './List';

interface State {
  data: List[];
}

export class AllListsTable extends React.Component<{}, State> {
  constructor(props: any) {
    super(props);
    this.state = {
      data: []
    };
  }

  componentDidMount() {
    fetch("/api/v1/lists")
      .then(response => response.json())
      .then(json => { this.setState({ data: json }); })
  }

  render() {
    return (
      <Table<List>
        dataSource={this.state.data}
        rowKey={record => record.id.toString()}
        loading={this.state.data.length === 0 ? true : false}
        size="middle"
        pagination={{ position: "top", size: "small" }} >
        <Table.Column<List>
          title="Name"
          dataIndex={nameof<List>("name")}
          width={250}
          fixed="left" />
        <Table.Column<List>
          title="Description"
          dataIndex={nameof<List>("description")} />
        <Table.Column<List> title="Subscribe"
          dataIndex={nameof<List>("viewUrl")}
          width={100}
          fixed="right"
          render={(text: string, record: List, index: number) => <SubscribeButton key={index} viewUrl={text} name={record.name} />}
        />
      </Table>
    );
  }
}