import { useState } from "react";
import {
  FilterValue,
  TableCurrentDataSource,
  TablePaginationConfig,
  SorterResult,
} from "antd/lib/table/interface";
import { FilterListSummary, OData } from "@/src/interfaces";
import { coalesceToArray } from "@/src/utils";

export const useListsTable = (props: OData<FilterListSummary[]>) => {
  const [dataSource, setData] = useState(props.value);
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: props["@odata.count"],
  } as TablePaginationConfig);
  const [loading, setLoading] = useState(false);

  const onChange = async (
    pagination: TablePaginationConfig,
    _filters: Record<string, FilterValue | null>,
    sorter: SorterResult<FilterListSummary> | SorterResult<FilterListSummary>[],
    _extra: TableCurrentDataSource<FilterListSummary>
  ) => {
    setLoading(true);

    const params = new URLSearchParams({
      $count: "true",
      $skip: (
        ((pagination.current ?? 0) - 1) *
        (pagination.pageSize ?? 0)
      ).toString(),
      $top: (pagination.pageSize ?? 0).toString(),
    });
    const orderBy = toODataOrderBy(sorter);
    if (orderBy.length) {
      params.append("$orderby", orderBy);
    }

    // TODO: use SWR? https://swr.vercel.app/
    const url =
      `${process.env.NEXT_PUBLIC_FILTERLISTS_API_URL}/lists?` + params;
    const response = await fetch(url);
    const jsonData = await response.json();

    setData(jsonData.value);
    setPagination({
      ...pagination,
      total: jsonData["@odata.count"],
    });

    setLoading(false);
  };

  const rowKey = (filterlist: FilterListSummary) => filterlist.id;

  return { dataSource, pagination, loading, onChange, rowKey };
};

const toODataOrderBy = (
  sorters: SorterResult<FilterListSummary> | SorterResult<FilterListSummary>[]
) =>
  coalesceToArray(sorters)
    .sort(
      (a, b) =>
        ((
          a.column?.sorter as {
            multiple?: number;
          }
        ).multiple ?? Number.MAX_VALUE) -
        ((
          b.column?.sorter as {
            multiple?: number;
          }
        ).multiple ?? Number.MAX_VALUE)
    )
    .filter((sorter) => sorter.order)
    .map(
      (sorter) =>
        `${sorter.field === "licenseId" ? "license/name" : sorter.field} ${
          sorter.order === "descend" ? "desc" : "asc"
        }`
    )
    .join(",");
