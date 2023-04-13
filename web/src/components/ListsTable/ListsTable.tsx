import { FilterList } from "@/src/interfaces";
import { Table } from "antd";
import { localeCompare } from "@/src/utils";

interface Props {
  lists: FilterList[];
}

export const ListsTable = (props: Props) => (
  <Table<FilterList> dataSource={props.lists} rowKey={(record) => record.id}>
    {nameColumn}
    {descriptionColumn}
  </Table>
);

const nameColumn = (
  <Table.Column<FilterList>
    dataIndex="name"
    title="Name"
    sorter={(a, b) => localeCompare({ a: a.name, b: b.name })}
  />
);

const descriptionColumn = (
  <Table.Column<FilterList>
    dataIndex="description"
    title="Description"
    sorter={(a, b) => localeCompare({ a: a.description, b: b.description })}
  />
);
