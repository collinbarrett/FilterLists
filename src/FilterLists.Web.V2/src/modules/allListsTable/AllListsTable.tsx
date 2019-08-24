import { Table } from 'antd';
import React from 'react';

import { Description, SubscribeButton, TagCloud } from '../../shared';
import { nameof } from '../../utils';
import styles from './AllListsTable.module.css';
import { List } from './List';
import { Tag } from './Tag';

interface State {
  lists: List[];
  tags: Tag[];
  pageSize: number;
  pageSizeOptions: string[];
  isNarrowWindow: boolean;
}

export class AllListsTable extends React.Component<{}, State> {
  constructor(props: any) {
    super(props);
    this.state = {
      lists: [],
      tags: [],
      pageSize: 0,
      pageSizeOptions: [],
      isNarrowWindow: false
    };
    this.updatePageSize = this.updatePageSize.bind(this);
  }

  componentDidMount() {
    this.fetchData();
    this.updatePageSize();
    window.addEventListener('resize', this.updatePageSize);
  }

  private fetchData() {
    fetch("/api/v1/lists")
      .then(response => response.json())
      .then(json => (json as List[]).sort((a, b) => a.name.localeCompare(b.name)))
      .then(lists => { this.setState({ lists: lists }); })

    fetch("/api/v1/tags")
      .then(response => response.json())
      .then(json => (json as Tag[]).sort((a, b) => a.name.localeCompare(b.name)))
      .then(tags => { this.setState({ tags: tags }); })
  }

  private updatePageSize() {
    const pageSize = Math.floor((window.innerHeight - 211.5) / 56);
    this.setState({
      pageSize: pageSize,
      pageSizeOptions: [5, 10, 20, 500, 2000, pageSize].sort((a, b) => a - b).map(String),
      isNarrowWindow: window.innerWidth < 576 ? true : false
    });
  }

  render() {
    return (
      <Table<List>
        dataSource={this.state.lists}
        rowKey={record => record.id.toString()}
        loading={this.state.lists.length ? false : true}
        size="small"
        pagination={{
          size: "small",
          pageSize: this.state.pageSize,
          showSizeChanger: true,
          pageSizeOptions: this.state.pageSizeOptions
        }}
        scroll={{ x: this.state.isNarrowWindow ? 576 : 1600 }}>
        <Table.Column<List>
          title="Name"
          dataIndex={nameof<List>("name")}
          sorter={(a, b) => a.name.localeCompare(b.name)}
          defaultSortOrder={"ascend"}
          width={200}
          className={styles.nogrow}
          fixed="left"
          render={(text: string) => <div>{text}</div>} />
        <Table.Column<List>
          title="Description"
          dataIndex={nameof<List>("description")}
          className={styles.nogrow}
          render={(text: string, record: List) =>
            <Description desriptionSourceUrl={record.descriptionSourceUrl} desription={text} />} />
        <Table.Column<List>
          title="Software"
          dataIndex={nameof<List>("syntaxId")}
          className={styles.nogrow}
          render={(text: string) => <div>{text}</div>} />
        <Table.Column<List>
          title="Languages"
          dataIndex={nameof<List>("languageIds")}
          className={styles.nogrow}
          render={(text: string) => <div>{text}</div>} />
        <Table.Column<List>
          title="Tags"
          dataIndex={nameof<List>("tagIds")}
          sorter={(a, b) => this.tagSorter(a.tagIds, b.tagIds, this.state.tags)}
          width={275}
          className={styles.nogrow}
          render={(tagIds: number[]) =>
            tagIds ? <TagCloud tags={this.state.tags.filter((t: Tag) => tagIds.includes(t.id))} /> : null} />
        <Table.Column<List> title="Subscribe"
          dataIndex={nameof<List>("viewUrl")}
          width={123}
          className={styles.nogrow}
          fixed={this.state.isNarrowWindow ? undefined : "right"}
          render={(text: string, record: List, index: number) =>
            <SubscribeButton key={index} viewUrl={text} viewUrlMirrors={record.viewUrlMirrors} name={record.name} />} />
      </Table>
    );
  }

  private tagSorter = (a: number[], b: number[], tags: Tag[]): number => {
    return a && a.length
      ? b && b.length
        ? a.length === b.length
          ? tags.filter((t: Tag) => a.indexOf(t.id) > -1).map((t: Tag) => t.name).join().toLowerCase() > tags.filter((t: Tag) => b.indexOf(t.id) > -1).map((t: Tag) => t.name).join().toLowerCase()
            ? 1
            : -1
          : a.length > b.length
            ? -1
            : 1
        : -1
      : 1;
  };

  componentWillUnmount() {
    window.removeEventListener('resize', this.updatePageSize);
  }
}