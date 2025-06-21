"use client";

import { ColumnDef } from "@tanstack/react-table";

export type FilterList = {
  name: string;
};

export const columns: ColumnDef<FilterList>[] = [
  {
    accessorKey: "name",
    header: "Name",
    cell: (info) => info.getValue(),
  },
];
