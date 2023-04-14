import { OData, FilterList } from "@/src/interfaces";
import { Table, TablePaginationConfig } from "antd";
import { localeCompare } from "@/src/utils";
import { useState } from "react";

export const ListsTable = (props: OData<FilterList>) => {
  const [data, setData] = useState(props.value);
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: props["@count"] ?? 0,
  });
  const [loading, setLoading] = useState(false);

  const handleTableChange = async (pagination: TablePaginationConfig) => {
    setLoading(true);
    try {
      const res = await fetch(
        process.env.NEXT_PUBLIC_FILTERLISTS_API_URL +
          "/lists?$skip=" +
          ((pagination.current ?? 0) - 1) * (pagination.pageSize ?? 0) +
          "$top=" +
          pagination.pageSize +
          "&$count=true"
      );
      const filterlists = (await res.json()) as OData<FilterList>;
      setData(filterlists.value);
      setPagination({
        current: pagination.current ?? 0,
        pageSize: pagination.pageSize ?? 0,
        total: filterlists["@count"] ?? 0,
      });
      setLoading(false);
    } catch (error) {
      setLoading(false);
      console.error("Failed to fetch data:", error);
    }
  };

  return (
    <Table<FilterList>
      dataSource={data}
      rowKey={(record) => record.id}
      pagination={pagination}
      loading={loading}
      onChange={handleTableChange}
    >
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
