"use client";

import { FilterList } from "@/services/get-filterlists";
import { createColumnHelper } from "@tanstack/react-table";
import { FilterListsTableMeta } from ".";

const columnHelper = createColumnHelper<FilterList>();

export const columns = [
  columnHelper.accessor((row) => row.name, {
    header: "Name",
  }),
  columnHelper.accessor((row) => row.description, {
    header: "Description",
  }),
  columnHelper.accessor((row) => row.licenseId, {
    header: "License",
    cell: (info) => {
      const meta = info.table.options.meta as FilterListsTableMeta;
      const license = meta.licenses.find((l) => l.id === info.getValue());
      return license?.name;
    },
  }),
];
