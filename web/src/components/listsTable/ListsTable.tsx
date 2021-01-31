import {
  Key,
  SorterResult,
  TableCurrentDataSource,
} from "antd/lib/table/interface";
import React, { useEffect, useState } from "react";
import { SoftwareCloud, SoftwareIcon } from "../softwareCloud";
import { Table, Tag } from "antd";
import { useSearchColumnFilter, useTablePageSizer } from "../../hooks";

import { Description } from "../Description";
import { Language } from "../../interfaces/Language";
import { LanguageCloud } from "../languageCloud";
import { SyntaxCloud } from "../syntaxCloud";
import { License } from "../../interfaces/License";
import { LicenseTag } from "../LicenseTag";
import { List } from "../../interfaces/List";
import { ListInfoButton } from "../ListInfoButton";
import { Maintainer } from "../../interfaces/Maintainer";
import { MaintainerCloud } from "../maintainerCloud";
import { RouteComponentProps } from "react-router";
import { Software } from "../../interfaces/Software";
import { Syntax } from "../../interfaces/Syntax";
import { TagCloud } from "../tagCloud";
import { Tag as TagInterface } from "../../interfaces/Tag";
import { arraySorter, languageArraySorter } from "./arraySorter";
import { nameof } from "../../utils";
import styles from "./ListsTable.module.css";
import { TablePaginationConfig } from "antd/lib/table";
import { SyntaxTag } from "../SyntaxTag";

interface Props {
  lists: List[];
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: TagInterface[];
}

export const ListsTable = (props: RouteComponentProps & Props) => {
  const {
    lists,
    languages,
    licenses,
    maintainers,
    software,
    syntaxes,
    tags,
    ...routeComponentProps
  } = props;
  const tablePageSize = useTablePageSizer();
  const searchNameColumn = useSearchColumnFilter<List>(nameof<List>("name"));
  const searchDescriptionColumn = useSearchColumnFilter<List>(
    nameof<List>("description")
  );
  const [visibleLists, setVisibleLists] = useState<List[]>(lists);
  useEffect(() => {
    setVisibleLists(lists);
  }, [lists]);
  return (
    <Table<List>
      dataSource={lists}
      rowKey={(record) => record.id.toString()}
      loading={lists.length ? false : true}
      size="small"
      pagination={{
        simple: true,
        style: { float: "left", margin: "4px 4px" },
        pageSize: tablePageSize.pageSize,
      }}
      scroll={{
        x:
          tablePageSize.isNarrowWindow || tablePageSize.isWideWindow
            ? undefined
            : 1892,
      }}
      onChange={(
        _pagination: TablePaginationConfig,
        _filters: Record<string, (Key | boolean)[] | null>,
        _sorter: SorterResult<List> | SorterResult<List>[],
        extra: TableCurrentDataSource<List>
      ) => setVisibleLists(extra.currentDataSource)}
    >
      <Table.Column<List>
        title="Info"
        key="Info"
        dataIndex={nameof<List>("id")}
        width={62}
        className={styles.nogrow}
        fixed={tablePageSize.isNarrowWindow ? undefined : "left"}
        render={(_id: number, list: List) => (
          <ListInfoButton listName={list.name} {...routeComponentProps} />
        )}
      />
      <Table.Column<List>
        title="Name"
        key="Name"
        dataIndex={nameof<List>("name")}
        sorter={(a, b) => a.name.localeCompare(b.name)}
        defaultSortOrder={"ascend"}
        width={tablePageSize.isNarrowWindow ? undefined : 200}
        className={styles.nogrow}
        fixed={tablePageSize.isNarrowWindow ? undefined : "left"}
        filterDropdown={searchNameColumn.filterDropdown}
        filterIcon={searchNameColumn.filterIcon}
        onFilter={searchNameColumn.onFilter}
        render={(name: string) => <div>{name}</div>}
      />
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Description"
          key="Description"
          dataIndex={nameof<List>("description")}
          sorter={(a, b) => a.description.localeCompare(b.description)}
          width={
            !tablePageSize.isNarrowWindow && !tablePageSize.isWideWindow
              ? 423
              : undefined
          }
          className={styles.nogrow}
          filterDropdown={searchDescriptionColumn.filterDropdown}
          filterIcon={searchDescriptionColumn.filterIcon}
          onFilter={searchDescriptionColumn.onFilter}
          render={(description: string) => (
            <Description description={description} />
          )}
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Software"
          key="Software"
          dataIndex={nameof<List>("syntaxIds")}
          sorter={(a, b) => {
            const getSoftwareIds = (l: List) =>
              software
                .filter(
                  (s: Software) =>
                    s.syntaxIds &&
                    s.syntaxIds.some((i) => l.syntaxIds.includes(i))
                )
                .map((s) => s.id);
            return arraySorter(getSoftwareIds(a), getSoftwareIds(b), software);
          }}
          width={170}
          className={styles.nogrow}
          filters={software.map((s) => ({
            text: (
              <>
                <SoftwareIcon id={s.id} />
                &nbsp;
                {s.name}&nbsp; (
                {
                  visibleLists.filter(
                    (l) =>
                      s.syntaxIds &&
                      s.syntaxIds.some((i) => l.syntaxIds.includes(i))
                  ).length
                }
                )
              </>
            ),
            value: s.name,
          }))}
          onFilter={(value, record) =>
            software
              .filter((s: Software) => s.name === value)
              .flatMap((s) => s.syntaxIds)
              .some((i) => record.syntaxIds.includes(i))
          }
          render={(syntaxIds: number[]) =>
            syntaxIds ? (
              <SoftwareCloud
                software={software.filter(
                  (s: Software) =>
                    s.syntaxIds &&
                    s.syntaxIds.some((i) => syntaxIds.includes(i))
                )}
              />
            ) : null
          }
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Syntaxes"
          key="Syntaxes"
          dataIndex={nameof<List>("syntaxIds")}
          sorter={(a, b) => arraySorter(a.syntaxIds, b.syntaxIds, syntaxes)}
          width={254}
          className={styles.nogrow}
          filters={syntaxes.map((s) => ({
            text: (
              <>
                <SyntaxTag name={s.name} showLabel={false} />
                &nbsp;(
                {
                  visibleLists.filter(
                    (li) => li.syntaxIds && li.syntaxIds.includes(s.id)
                  ).length
                }
                )
              </>
            ),
            value: s.id,
          }))}
          onFilter={(value, record) =>
            record.syntaxIds
              ? record.syntaxIds.includes(value as number)
              : false
          }
          render={(syntaxIds: number[]) =>
            syntaxIds ? (
              <SyntaxCloud
                syntaxes={syntaxes.filter((s: Syntax) =>
                  syntaxIds.includes(s.id)
                )}
              />
            ) : null
          }
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Languages"
          key="Languages"
          dataIndex={nameof<List>("iso6391s")}
          sorter={(a, b) =>
            languageArraySorter(a.iso6391s, b.iso6391s, languages)
          }
          width={129}
          className={styles.nogrow}
          filters={languages.map((l) => ({
            text: (
              <>
                <Tag title={l.name}>{l.iso6391}</Tag>&nbsp;
                {l.name}&nbsp; (
                {
                  visibleLists.filter(
                    (li) => li.iso6391s && li.iso6391s.includes(l.iso6391)
                  ).length
                }
                )
              </>
            ),
            value: l.iso6391.toString(),
          }))}
          onFilter={(value, record) =>
            record.iso6391s ? record.iso6391s.includes(value as string) : false
          }
          render={(languageIds: string[]) =>
            languageIds ? (
              <LanguageCloud
                languages={languages.filter((l: Language) =>
                  languageIds.includes(l.iso6391)
                )}
              />
            ) : null
          }
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Tags"
          key="Tags"
          dataIndex={nameof<List>("tagIds")}
          sorter={(a, b) => arraySorter(a.tagIds, b.tagIds, tags)}
          width={275}
          className={styles.nogrow}
          filters={tags.map((t) => ({
            text: (
              <>
                <Tag title={t.description}>{t.name}</Tag>(
                {
                  visibleLists.filter(
                    (l) => l.tagIds && l.tagIds.includes(t.id)
                  ).length
                }
                )
              </>
            ),
            value: t.id.toString(),
          }))}
          onFilter={(value, record) =>
            record.tagIds ? record.tagIds.includes(+value) : false
          }
          render={(tagIds: number[]) =>
            tagIds ? (
              <TagCloud
                tags={tags.filter((t: TagInterface) => tagIds.includes(t.id))}
              />
            ) : null
          }
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="Maintainers"
          key="Maintainers"
          dataIndex={nameof<List>("maintainerIds")}
          sorter={(a, b) =>
            arraySorter(a.maintainerIds, b.maintainerIds, maintainers)
          }
          width={191}
          className={styles.nogrow}
          filters={maintainers.map((t) => ({
            text: (
              <>
                <Tag title={t.name}>{t.name}</Tag>(
                {
                  visibleLists.filter(
                    (l) => l.maintainerIds && l.maintainerIds.includes(t.id)
                  ).length
                }
                )
              </>
            ),
            value: t.id.toString(),
          }))}
          onFilter={(value, record) =>
            record.maintainerIds ? record.maintainerIds.includes(+value) : false
          }
          render={(maintainerIds: number[]) =>
            maintainerIds ? (
              <MaintainerCloud
                maintainers={maintainers.filter((t: Maintainer) =>
                  maintainerIds.includes(t.id)
                )}
              />
            ) : null
          }
        />
      )}
      {tablePageSize.isNarrowWindow ? null : (
        <Table.Column<List>
          title="License"
          key="License"
          dataIndex={nameof<List>("licenseId")}
          sorter={(a, b) => {
            const licenseA = licenses.find((s) => s.id === a.licenseId);
            const licenseB = licenses.find((s) => s.id === b.licenseId);
            return licenseA
              ? licenseB
                ? licenseA.name.localeCompare(licenseB.name)
                : -1
              : 1;
          }}
          width={215}
          className={styles.nogrow}
          filters={licenses.map((l) => ({
            text: (
              <>
                <LicenseTag name={l.name} showLabel={false} />(
                {
                  visibleLists.filter(
                    (li) => li.licenseId && li.licenseId === l.id
                  ).length
                }
                )
              </>
            ),
            value: l.id.toString(),
          }))}
          onFilter={(value, record) =>
            record.licenseId ? record.licenseId.toString() === value : false
          }
          render={(licenseId: number) => {
            const license = licenses.find((l) => l.id === licenseId);
            return license ? (
              <LicenseTag
                name={license.name}
                url={license.url}
                showLabel={false}
              />
            ) : null;
          }}
        />
      )}
    </Table>
  );
};
