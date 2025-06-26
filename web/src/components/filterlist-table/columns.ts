import { FilterList } from "@/services/get-filterlists";
import { createColumnHelper } from "@tanstack/react-table";

const columnHelper = createColumnHelper<FilterList>();

export const columns = [
  columnHelper.accessor("name", {
    header: "Name",
  }),
  columnHelper.accessor("description", {
    header: "Description",
  }),
];
