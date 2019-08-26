import { Table } from 'antd';
import React from 'react';
import { Redirect, Route, RouteComponentProps } from 'react-router-dom';

import { Language } from '../../interfaces/Language';
import { List } from '../../interfaces/List';
import { Tag } from '../../interfaces/Tag';
import { nameof } from '../../utils';
import { Description } from '../Description';
import { LanguageCloud } from '../languageCloud';
import { ListInfoButton } from '../ListInfoButton';
import { ListInfoDrawer } from '../ListInfoDrawer';
import { TagCloud } from '../tagCloud';
import styles from './ListsTable.module.css';

interface State {
  lists: List[];
  languages: Language[];
  tags: Tag[];
  pageSize: number;
  isNarrowWindow: boolean;
}

export class ListsTable extends React.Component<RouteComponentProps, State> {
  constructor(props: any) {
    super(props);
    this.state = {
      lists: [],
      languages: [],
      tags: [],
      pageSize: 0,
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

    fetch("/api/v1/languages")
      .then(response => response.json())
      .then(json => (json as Language[]).sort((a, b) => a.name.localeCompare(b.name)))
      .then(languages => { this.setState({ languages: languages }); })

    fetch("/api/v1/tags")
      .then(response => response.json())
      .then(json => (json as Tag[]).sort((a, b) => a.name.localeCompare(b.name)))
      .then(tags => { this.setState({ tags: tags }); })
  }

  private updatePageSize() {
    this.setState({
      pageSize: Math.floor((window.innerHeight - 211.5) / 56),
      isNarrowWindow: window.innerWidth < 576 ? true : false
    });
  }

  render() {
    return (
      <span>
        <Table<List>
          dataSource={this.state.lists}
          rowKey={record => record.id.toString()}
          loading={this.state.lists.length ? false : true}
          size="small"
          pagination={{
            size: "small",
            simple: true,
            style: { float: "left" },
            pageSize: this.state.pageSize
          }}
          scroll={{ x: this.state.isNarrowWindow ? undefined : 1200 }}>
          <Table.Column<List>
            title="Info"
            dataIndex={nameof<List>("viewUrl")}
            className={styles.nogrow}
            fixed="left"
            render={(_text: string, record: List) => <ListInfoButton list={record} {...this.props} />} />
          <Table.Column<List>
            title="Name"
            dataIndex={nameof<List>("name")}
            sorter={(a, b) => a.name.localeCompare(b.name)}
            defaultSortOrder={"ascend"}
            width={this.state.isNarrowWindow ? undefined : 200}
            className={styles.nogrow}
            fixed="left"
            render={(text: string) => <div>{text}</div>} />
          {this.state.isNarrowWindow
            ? null
            : <Table.Column<List>
              title="Description"
              dataIndex={nameof<List>("description")}
              className={styles.nogrow}
              render={(_text: string, record: List) => <Description {...record} />} />}
          {this.state.isNarrowWindow
            ? null
            : <Table.Column<List>
              title="Software"
              dataIndex={nameof<List>("syntaxId")}
              className={styles.nogrow}
              render={(text: string) => <div>{text}</div>} />}
          {this.state.isNarrowWindow
            ? null
            : <Table.Column<List>
              title="Languages"
              dataIndex={nameof<List>("languageIds")}
              sorter={(a, b) => arraySorter(a.languageIds, b.languageIds, this.state.languages)}
              width={125}
              className={styles.nogrow}
              render={(languageIds: number[]) =>
                languageIds
                  ? <LanguageCloud languages={this.state.languages.filter((l: Language) => languageIds.includes(l.id))} />
                  : null} />}
          {this.state.isNarrowWindow
            ? null
            : <Table.Column<List>
              title="Tags"
              dataIndex={nameof<List>("tagIds")}
              sorter={(a, b) => arraySorter(a.tagIds, b.tagIds, this.state.tags)}
              width={275}
              className={styles.nogrow}
              render={(tagIds: number[]) =>
                tagIds
                  ? <TagCloud tags={this.state.tags.filter((t: Tag) => tagIds.includes(t.id))} />
                  : null} />}
        </Table>
        <Route path="/lists/:id" render={props => {
          const list = this.state.lists.find(l => l.id === +props.match.params.id);
          return list
            ? <ListInfoDrawer list={list as List} {...props} {...this.state} />
            : this.state.lists && this.state.lists.length && <Redirect to={{ pathname: "/", }} />
        }} />
      </span>
    );
  }

  componentWillUnmount() {
    window.removeEventListener('resize', this.updatePageSize);
  }
}

interface ArraySortableEntity {
  id: number;
  name: string;
}

const arraySorter = (a: number[], b: number[], entities: ArraySortableEntity[]): number =>
  a && a.length
    ? b && b.length
      ? a.length === b.length
        ? entities.filter((e: ArraySortableEntity) => a.indexOf(e.id) > -1).map((e: ArraySortableEntity) => e.name).join().toLowerCase()
          > entities.filter((e: ArraySortableEntity) => b.indexOf(e.id) > -1).map((e: ArraySortableEntity) => e.name).join().toLowerCase()
          ? 1
          : -1
        : a.length > b.length
          ? -1
          : 1
      : -1
    : 1;