import { Table, Tag } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router';

import { useSearchColumnFilter, useTablePageSizer } from '../../hooks';
import { Language } from '../../interfaces/Language';
import { License } from '../../interfaces/License';
import { List } from '../../interfaces/List';
import { Software } from '../../interfaces/Software';
import { Tag as TagInterface } from '../../interfaces/Tag';
import { nameof } from '../../utils';
import { Description } from '../Description';
import { LanguageCloud } from '../languageCloud';
import { ListInfoButton } from '../ListInfoButton';
import { SoftwareCloud, SoftwareIcon } from '../softwareCloud';
import { TagCloud } from '../tagCloud';
import { arraySorter } from './arraySorter';
import styles from './ListsTable.module.css';

interface Props {
    lists: List[];
    languages: Language[];
    licenses: License[];
    software: Software[];
    tags: TagInterface[];
};

export const ListsTable = (props: RouteComponentProps & Props) => {
    const { lists, languages, licenses, software, tags, ...routeComponentProps } = props;
    const tablePageSize = useTablePageSizer();
    const searchNameColumn = useSearchColumnFilter<List>(nameof<List>("name"));
    const searchDescriptionColumn = useSearchColumnFilter<List>(nameof<List>("description"));
    return (
        <Table<List>
            dataSource={lists}
            rowKey={record => record.id.toString()}
            loading={lists.length ? false : true}
            size="small"
            pagination={{
                size: "small",
                simple: true,
                style: { float: "left" },
                pageSize: tablePageSize.pageSize
            }}
            scroll={{ x: tablePageSize.isNarrowWindow ? undefined : 1200 }}>
            <Table.Column<List>
                title="Info"
                dataIndex={nameof<List>("id")}
                className={styles.nogrow}
                fixed="left"
                render={(_id: number, list: List) =>
                    <ListInfoButton listName={list.name} {...routeComponentProps} />} />
            <Table.Column<List>
                title="Name"
                dataIndex={nameof<List>("name")}
                sorter={(a, b) => a.name.localeCompare(b.name)}
                defaultSortOrder={"ascend"}
                width={tablePageSize.isNarrowWindow ? undefined : 200}
                className={styles.nogrow}
                fixed="left"
                filterDropdown={searchNameColumn.filterDropdown}
                filterIcon={searchNameColumn.filterIcon}
                onFilter={searchNameColumn.onFilter}
                render={(name: string) =>
                    <div>{name}</div>} />
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Description"
                    dataIndex={nameof<List>("description")}
                    className={styles.nogrow}
                    filterDropdown={searchDescriptionColumn.filterDropdown}
                    filterIcon={searchDescriptionColumn.filterIcon}
                    onFilter={searchDescriptionColumn.onFilter}
                    render={(description: string, list: List) =>
                        <Description
                            description={description}
                            descriptionSourceUrl={list.descriptionSourceUrl} />} />}
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Software"
                    dataIndex={nameof<List>("syntaxId")}
                    sorter={(a, b) => {
                        const getSoftwareIds = (l: List) => software.filter((s: Software) => s.syntaxIds.includes(l.syntaxId)).map(s => s.id);
                        return arraySorter(getSoftwareIds(a), getSoftwareIds(b), software);
                    }}
                    width={143}
                    className={styles.nogrow}
                    filters={software.map(s => ({
                        text: <>
                            <SoftwareIcon id={s.id} />&nbsp;
                            {s.name}
                        </>,
                        value: s.name
                    }))}
                    onFilter={(value, record) => software.filter((s: Software) => s.name === value).flatMap(s => s.syntaxIds).includes(record.syntaxId)}
                    render={(syntaxId: number) =>
                        syntaxId
                            ? <SoftwareCloud software={software.filter((s: Software) => s.syntaxIds.includes(syntaxId))} />
                            : null} />}
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Languages"
                    dataIndex={nameof<List>("languageIds")}
                    sorter={(a, b) => arraySorter(a.languageIds, b.languageIds, languages)}
                    width={125}
                    className={styles.nogrow}
                    filters={languages.map(l => ({
                        text: <>
                            <Tag title={l.name}>{l.iso6391}</Tag>&nbsp;
                            {l.name}
                        </>,
                        value: l.id.toString()
                    }))}
                    onFilter={(value, record) => record.languageIds
                        ? record.languageIds.includes(+value)
                        : false}
                    render={(languageIds: number[]) =>
                        languageIds
                            ? <LanguageCloud languages={languages.filter((l: Language) => languageIds.includes(l.id))} />
                            : null} />}
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Tags"
                    dataIndex={nameof<List>("tagIds")}
                    sorter={(a, b) => arraySorter(a.tagIds, b.tagIds, tags)}
                    width={275}
                    className={styles.nogrow}
                    filters={tags.map(t => ({
                        text: <Tag title={t.description}>{t.name}</Tag>,
                        value: t.id.toString()
                    }))}
                    onFilter={(value, record) => record.tagIds
                        ? record.tagIds.includes(+value)
                        : false}
                    render={(tagIds: number[]) =>
                        tagIds
                            ? <TagCloud tags={tags.filter((t: TagInterface) => tagIds.includes(t.id))} />
                            : null} />}
        </Table>
    );
};