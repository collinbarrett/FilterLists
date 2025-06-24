"use client";

import * as React from "react";
import {
  useReactTable,
  getCoreRowModel,
  getPaginationRowModel,
  flexRender,
  AccessorKeyColumnDef,
} from "@tanstack/react-table";
import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table";
import { FilterList } from "./columns";
import { useEffect, useState } from "react";
import { FilterListTablePagination } from "./pagination";
import { FilterListTablePaginationSkeleton } from "./skeleton";

interface FilterListTableProps {
  columns: AccessorKeyColumnDef<FilterList, string>[];
  initialData: FilterList[];
}

export function FilterListTable({
  columns,
  initialData,
}: FilterListTableProps) {
  const [data, setData] = useState<FilterList[]>(initialData);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    async function fetchAll() {
      try {
        const response = await fetch("https://api.filterlists.com/lists");
        const lists = await response.json();
        setData(lists);
      } finally {
        setLoading(false);
      }
    }
    fetchAll();
  }, [initialData.length]);

  const table = useReactTable({
    data,
    columns,
    getCoreRowModel: getCoreRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
  });

  return (
    <div className="space-y-2">
      <Table>
        <TableHeader>
          {table.getHeaderGroups().map((headerGroup) => (
            <TableRow key={headerGroup.id}>
              {headerGroup.headers.map((header) => (
                <TableHead key={header.id}>
                  {flexRender(
                    header.column.columnDef.header,
                    header.getContext(),
                  )}
                </TableHead>
              ))}
            </TableRow>
          ))}
        </TableHeader>
        <TableBody>
          {table.getRowModel().rows.map((row) => (
            <TableRow key={row.id}>
              {row.getVisibleCells().map((cell) => (
                <TableCell key={cell.id}>
                  {flexRender(cell.column.columnDef.cell, cell.getContext())}
                </TableCell>
              ))}
            </TableRow>
          ))}
        </TableBody>
      </Table>
      {loading ? (
        <FilterListTablePaginationSkeleton />
      ) : (
        <FilterListTablePagination table={table} />
      )}
    </div>
  );
}
