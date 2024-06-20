"use client";

import { ArrowDownIcon, ArrowUpIcon } from "@radix-ui/react-icons";
import { ColumnDef } from "@tanstack/react-table";

import { Button } from "@/components/ui/button";

import { FilterList } from "./filterlist";

export const columns: ColumnDef<FilterList>[] = [
  {
    accessorKey: "name",
    header: ({ column }) => {
      const isSorted = column.getIsSorted();
      return (
        <Button
          variant="ghost"
          onClick={() => column.toggleSorting(isSorted === "asc")}
        >
          Name
          {isSorted === "asc" && <ArrowUpIcon className="ml-2 h-4 w-4" />}
          {isSorted === "desc" && <ArrowDownIcon className="ml-2 h-4 w-4" />}
        </Button>
      );
    },
  },
  {
    accessorKey: "description",
    header: ({ column }) => {
      const isSorted = column.getIsSorted();
      return (
        <Button
          variant="ghost"
          onClick={() => column.toggleSorting(isSorted === "asc")}
        >
          Description
          {isSorted === "asc" && <ArrowUpIcon className="ml-2 h-4 w-4" />}
          {isSorted === "desc" && <ArrowDownIcon className="ml-2 h-4 w-4" />}
        </Button>
      );
    },
  },
];
