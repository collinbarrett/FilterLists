import { Space, Table } from "antd";
import { useListsTable } from "./useListsTable";
import { OData, FilterList } from "@/src/interfaces";
import { localeCompare } from "@/src/utils";
import { ShowListButton } from "./components";

export const ListsTable = (props: OData<FilterList>) => (
  <Table<FilterList> {...useListsTable(props)}>
    <Table.Column<FilterList>
      dataIndex="name"
      title="Name"
      sorter={{
        compare: (a, b) => localeCompare({ a: a.name, b: b.name }),
        multiple: 1,
      }}
    />
    <Table.Column<FilterList>
      dataIndex="description"
      title="Description"
      sorter={{
        compare: (a, b) =>
          localeCompare({ a: a.description, b: b.description }),
        multiple: 2,
      }}
    />
    <Table.Column<FilterList>
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
