import { OData, FilterList } from "@/src/interfaces";
import { Table } from "antd";
import { localeCompare } from "@/src/utils";

export const ListsTable = (props: OData<FilterList>) => {
  return (
    <Table<FilterList> dataSource={props.value} rowKey={(record) => record.id}>
      {nameColumn}
      {descriptionColumn}
    </Table>
  );
};

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
