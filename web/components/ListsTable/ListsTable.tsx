import { FilterList } from "@/interfaces";
import { Table } from "antd";
import { localeCompare } from "@/utils";

interface Props {
  lists: FilterList[];
}

export const ListsTable = (props: Props) => (
  <Table<FilterList> dataSource={props.lists} rowKey={(record) => record.id}>
    <Table.Column<FilterList>
      key="name"
      title="Name"
      dataIndex="name"
      sorter={(a, b) => localeCompare({ a: a.name, b: b.name })}
    />
    <Table.Column<FilterList>
      key="description"
      title="Description"
      dataIndex="description"
      sorter={(a, b) => localeCompare({ a: a.description, b: b.description })}
    />
  </Table>
);
