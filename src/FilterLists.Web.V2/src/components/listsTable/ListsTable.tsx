import { Table } from 'antd';
import React from 'react';
import { RouteComponentProps } from 'react-router';

import { useTablePageSizer } from '../../hooks';
import { Language } from '../../interfaces/Language';
import { License } from '../../interfaces/License';
import { List } from '../../interfaces/List';
import { Software } from '../../interfaces/Software';
import { Tag } from '../../interfaces/Tag';
import { nameof } from '../../utils';
import { Description } from '../Description';
import { LanguageCloud } from '../languageCloud';
import { ListInfoButton } from '../ListInfoButton';
import { SoftwareCloud } from '../softwareCloud';
import { TagCloud } from '../tagCloud';
import { arraySorter } from './arraySorter';
import styles from './ListsTable.module.css';

interface Props {
    lists: List[];
    languages: Language[];
    licenses: License[];
    software: Software[];
    tags: Tag[];
};

export const ListsTable = (props: RouteComponentProps & Props) => {
    const tablePageSize = useTablePageSizer();
    return (
        <Table<List>
            dataSource={props.lists}
            rowKey={record => record.id.toString()}
            loading={props.lists.length ? false : true}
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
                    sorter={(a, b) => {
                        const getSoftwareIds = (l: List) => props.software.filter((s: Software) => s.syntaxIds.includes(l.syntaxId)).map(s => s.id);
                        const aSoftwareIds = getSoftwareIds(a);
                        const bSoftwareIds = getSoftwareIds(b);
                        return arraySorter(aSoftwareIds, bSoftwareIds, props.software);
                    }}
                    width={140}
                    className={styles.nogrow}
                    render={(syntaxId: number) => syntaxId ? <SoftwareCloud software={props.software.filter((s: Software) => s.syntaxIds.includes(syntaxId))} /> : null} />}
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Languages"
                    dataIndex={nameof<List>("languageIds")}
                    sorter={(a, b) => arraySorter(a.languageIds, b.languageIds, props.languages)}
                    width={125}
                    className={styles.nogrow}
                    render={(languageIds: number[]) => languageIds ? <LanguageCloud languages={props.languages.filter((l: Language) => languageIds.includes(l.id))} /> : null} />}
            {tablePageSize.isNarrowWindow
                ? null
                : <Table.Column<List>
                    title="Tags"
                    dataIndex={nameof<List>("tagIds")}
                    sorter={(a, b) => arraySorter(a.tagIds, b.tagIds, props.tags)}
                    width={275}
                    className={styles.nogrow}
                    render={(tagIds: number[]) => tagIds ? <TagCloud tags={props.tags.filter((t: Tag) => tagIds.includes(t.id))} /> : null} />}
        </Table>
    );
};