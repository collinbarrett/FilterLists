import { FilterList } from "@/interfaces/FilterList";
import { Table } from "antd";

interface Props {
  lists: FilterList[];
}

export const ListsTable = (props: Props) => (
  <Table<FilterList> dataSource={props.lists} rowKey={(record) => record.id}>
    <Table.Column<FilterList> key="name" title="Name" dataIndex="name" />
  </Table>
);
