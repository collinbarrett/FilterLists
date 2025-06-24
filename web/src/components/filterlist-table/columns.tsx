"use client";

import { ColumnDef } from "@tanstack/react-table";

export type FilterList = {
  name: string;
  description: string;
};

export const columns: ColumnDef<FilterList>[] = [
  {
    accessorKey: "name",
    header: "Name",
  },
  {
    accessorKey: "description",
    header: "Description",
  },
];
