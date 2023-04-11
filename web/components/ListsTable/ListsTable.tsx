import { FilterList } from "@/interfaces";
import { Table } from "antd";

interface Props {
  lists: FilterList[];
}

export const ListsTable = (props: Props) => (
  <Table<FilterList> dataSource={props.lists} rowKey={(record) => record.id}>
    <Table.Column<FilterList>
      key="name"
      title="Name"
      dataIndex="name"
      sorter={(a, b) => a.name.localeCompare(b.name)}
    />
    <Table.Column<FilterList>
      key="description"
      title="Description"
      dataIndex="description"
      sorter={(a, b) => localeCompare(a.description, b.description)}
    />
  </Table>
);

function localeCompare(a?: string, b?: string): number {
  return a ? (b ? a.localeCompare(b) : -1) : 1;
}
