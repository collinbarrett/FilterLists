import { Space, Table } from "antd";
import { useListsTable } from "./useListsTable";
import { FilterListSummary, FilterListTable } from "@/src/interfaces";
import {
  LanguageTags,
  LicenseTag,
  MaintainerTags,
  ShowListButton,
  SyntaxTags,
  TagTags,
} from "./components";

export const ListsTable = ({
  filterLists,
  languages,
  licenses,
  maintainers,
  software,
  syntaxes,
  tags,
}: FilterListTable) => (
  <Table<FilterListSummary> {...useListsTable({ ...filterLists })}>
    <Table.Column<FilterListSummary>
      dataIndex="name"
      title="Name"
      sorter={{
        multiple: 1,
      }}
    />
    <Table.Column<FilterListSummary>
      dataIndex="description"
      title="Description"
      sorter={{
        multiple: 3,
      }}
    />
    <Table.Column<FilterListSummary>
      dataIndex="softwareIds"
      title="Software"
      render={() => "TODO"}
    />
    <Table.Column<FilterListSummary>
      dataIndex="languageIds"
      title="Languages"
      render={(languageIds: number[]) => (
        <LanguageTags
          languages={languages.filter((l) => languageIds.includes(l.id))}
        />
      )}
    />
    <Table.Column<FilterListSummary>
      dataIndex="tagIds"
      title="Tags"
      render={(tagIds: number[]) => (
        <TagTags tags={tags.filter((t) => tagIds.includes(t.id))} />
      )}
    />
    <Table.Column<FilterListSummary>
      dataIndex="maintainerIds"
      title="Maintainers"
      render={(maintainerIds: number[]) => (
        <MaintainerTags
          maintainers={maintainers.filter((m) => maintainerIds.includes(m.id))}
        />
      )}
    />
    <Table.Column<FilterListSummary>
      dataIndex="syntaxIds"
      title="Syntaxes"
      render={(syntaxIds: number[]) => (
        <SyntaxTags
          syntaxes={syntaxes.filter((s) => syntaxIds.includes(s.id))}
        />
      )}
    />
    <Table.Column<FilterListSummary>
      dataIndex="licenseId"
      title="License"
      sorter={{
        multiple: 2,
      }}
      render={(licenseId) => {
        const license = licenses.find((l) => l.id === licenseId);
        return license && <LicenseTag {...license} />;
      }}
    />
    <Table.Column<FilterListSummary>
      dataIndex="id"
      title="Actions"
      render={(id, filterlist) => (
        <Space>
          <ShowListButton listId={id} listName={filterlist.name} />
        </Space>
      )}
    />
  </Table>
);
