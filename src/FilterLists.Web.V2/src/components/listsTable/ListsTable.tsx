import { Table } from 'antd';
import React from 'react';
import { Redirect, Route, RouteComponentProps } from 'react-router-dom';

import { useLanguages, useLicenses, useLists, useTablePageSizer, useTags } from '../../hooks';
import { Language } from '../../interfaces/Language';
import { License } from '../../interfaces/License';
import { List } from '../../interfaces/List';
import { Tag } from '../../interfaces/Tag';
import { nameof } from '../../utils';
import { Description } from '../Description';
import { LanguageCloud } from '../languageCloud';
import { ListInfoButton } from '../ListInfoButton';
import { ListInfoDrawer } from '../ListInfoDrawer';
import { TagCloud } from '../tagCloud';
import styles from './ListsTable.module.css';

export const ListsTable = (props: RouteComponentProps) => {
  const lists = useLists();
  const languages = useLanguages();
  const licenses = useLicenses();
  const tags = useTags();
  const tablePageSize = useTablePageSizer();

  return (
    <span>
      <Table<List>
        dataSource={lists}
        rowKey={record => record.id.toString()}
        loading={lists.length ? false : true}
        size="small"
        pagination={{ size: "small", simple: true, style: { float: "left" }, pageSize: tablePageSize.pageSize }}
        scroll={{ x: tablePageSize.isNarrowWindow ? undefined : 1200 }}>
        <Table.Column<List>
          title="Info"
          dataIndex={nameof<List>("id")}
          className={styles.nogrow}
          fixed="left"
          render={(_text: string, record: List) => <ListInfoButton list={record} {...props} />} />
        <Table.Column<List>
          title="Name"
          dataIndex={nameof<List>("name")}
          sorter={(a, b) => a.name.localeCompare(b.name)}
          defaultSortOrder={"ascend"}
          width={tablePageSize.isNarrowWindow ? undefined : 200}
          className={styles.nogrow}
          fixed="left"
          render={(text: string) => <div>{text}</div>} />
        {tablePageSize.isNarrowWindow
          ? null
          : <Table.Column<List>
            title="Description"
            dataIndex={nameof<List>("description")}
            className={styles.nogrow}
            render={(_text: string, record: List) => <Description {...record} />} />}
        {tablePageSize.isNarrowWindow
          ? null
          : <Table.Column<List>
            title="Software"
            dataIndex={nameof<List>("syntaxId")}
            className={styles.nogrow}
            render={(text: string) => <div>{text}</div>} />}
        {tablePageSize.isNarrowWindow
          ? null
          : <Table.Column<List>
            title="Languages"
            dataIndex={nameof<List>("languageIds")}
            sorter={(a, b) => arraySorter(a.languageIds, b.languageIds, languages)}
            width={125}
            className={styles.nogrow}
            render={(languageIds: number[]) => languageIds ? <LanguageCloud languages={languages.filter((l: Language) => languageIds.includes(l.id))} /> : null} />}
        {tablePageSize.isNarrowWindow
          ? null
          : <Table.Column<List>
            title="Tags"
            dataIndex={nameof<List>("tagIds")}
            sorter={(a, b) => arraySorter(a.tagIds, b.tagIds, tags)}
            width={275}
            className={styles.nogrow}
            render={(tagIds: number[]) => tagIds ? <TagCloud tags={tags.filter((t: Tag) => tagIds.includes(t.id))} /> : null} />}
      </Table>
      <Route path="/lists/:id" render={rp => {
        const list = lists.find(l => l.id === +rp.match.params.id);
        return list
          ? <ListInfoDrawer
            list={list as List}
            languages={list.languageIds && languages.filter((l: Language) => list.languageIds.includes(l.id))}
            license={list.licenseId ? licenses.find((l: License) => list.licenseId === l.id) : undefined}
            tags={list.tagIds && tags.filter((t: Tag) => list.tagIds.includes(t.id))}
            {...props} />
          : lists && lists.length && <Redirect to={{ pathname: "/", }} />
      }} />
    </span>
  );
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