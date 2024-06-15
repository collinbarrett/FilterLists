"use client";

import { ColumnDef } from "@tanstack/react-table";

export type FilterList = {
  id: number;
  name: string;
  description?: string | null;
  licenseId: number;
  syntaxIds: number[];
  languageIds: number[];
  tagIds: number[];
  primaryViewUrl?: string | null;
  maintainerIds: number[];
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
