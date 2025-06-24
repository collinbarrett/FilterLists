import { createColumnHelper } from "@tanstack/react-table";

export type FilterList = {
  name: string;
  description: string;
};

const columnHelper = createColumnHelper<FilterList>();

export const columns = [
  columnHelper.accessor("name", {
    header: "Name",
  }),
  columnHelper.accessor("description", {
    header: "Description",
  }),
];
