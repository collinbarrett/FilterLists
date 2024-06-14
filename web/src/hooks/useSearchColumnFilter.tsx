import { SearchOutlined } from "@ant-design/icons";
import { Button, Input } from "antd";
import React, { useEffect, useState } from "react";
import {
  FilterConfirmProps,
  FilterDropdownProps,
} from "antd/lib/table/interface";

interface FilterPropsState<T> {
  filterDropdown?:
    | React.ReactNode
    | ((props: FilterDropdownProps) => React.ReactNode);
  filterIcon?: React.ReactNode | ((filtered: boolean) => React.ReactNode);
  onFilter?: (value: any, record: T) => boolean;
}

export const useSearchColumnFilter = <T extends {}>(dataIndex: string) => {
  const [filterProps, setFilterProps] = useState<FilterPropsState<T>>({
    filterDropdown: undefined,
    filterIcon: undefined,
    onFilter: undefined,
  });
  useEffect(() => {
    const handleSearch = (confirm?: (param: FilterConfirmProps) => void) => {
      confirm && confirm({ closeDropdown: true });
    };
    const handleReset = (clearFilters?: (selectedKeys: string[]) => void) => {
      clearFilters && clearFilters([]);
    };
    setFilterProps({
      filterDropdown: ({
        setSelectedKeys,
        selectedKeys,
        confirm,
        clearFilters,
      }) => (
        <div style={{ padding: 8 }}>
          <Input
            placeholder={`Search ${
              dataIndex.charAt(0).toUpperCase() + dataIndex.slice(1)
            }`}
            value={(selectedKeys && (selectedKeys[0] as string)) || ""}
            onChange={(e) =>
              setSelectedKeys &&
              setSelectedKeys(e.target.value ? [e.target.value] : [])
            }
            onPressEnter={() => handleSearch(confirm)}
            style={{ width: 188, marginBottom: 8, display: "block" }}
          />
          <Button
            type="primary"
            onClick={() => handleSearch(confirm)}
            icon={<SearchOutlined />}
            size="small"
            style={{ width: 90, marginRight: 8 }}
          >
            Search
          </Button>
          <Button
            onClick={() => handleReset(clearFilters)}
            size="small"
            style={{ width: 90 }}
          >
            Reset
          </Button>
        </div>
      ),
      filterIcon: (filtered) => (
        <SearchOutlined style={{ color: filtered ? "#1890ff" : undefined }} />
      ),
      onFilter: (value, record) => {
        const searchValue = (record as any)[dataIndex];
        return (
          searchValue &&
          searchValue
            .toString()
            .toLowerCase()
            .includes(value.toString().toLowerCase())
        );
      },
    });
  }, [dataIndex]);
  return filterProps;
};
