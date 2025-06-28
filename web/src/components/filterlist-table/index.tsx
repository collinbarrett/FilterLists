"use client";

import { useEffect, useState } from "react";
import {
  useReactTable,
  getCoreRowModel,
  getPaginationRowModel,
  flexRender,
  TableMeta,
} from "@tanstack/react-table";
import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table";
import { columns } from "./columns";
import { FilterListTablePagination } from "./pagination";
import { FilterListTablePaginationSkeleton } from "./pagination-skeleton";
import { FilterList, getFilterLists } from "@/services/get-filterlists";
import { Language } from "@/services/get-languages";
import { License } from "@/services/get-licenses";
import { Maintainer } from "@/services/get-maintainers";
import { Software } from "@/services/get-software";
import { Syntax } from "@/services/get-syntaxes";
import { Tag } from "@/services/get-tags";

export interface FilterListsTableMeta extends TableMeta<FilterList> {
  languages: readonly Language[];
  licenses: readonly License[];
  syntaxes: readonly Syntax[];
  tags: readonly Tag[];
}

type FilterListTableProps = {
  columns: typeof columns;
  initialFilterLists: FilterList[];
  languages: readonly Language[];
  licenses: readonly License[];
  maintainers: readonly Maintainer[];
  software: readonly Software[];
  syntaxes: readonly Syntax[];
  tags: readonly Tag[];
};

export function FilterListTable({
  columns,
  initialFilterLists,
  languages,
  licenses,
  syntaxes,
  tags,
}: FilterListTableProps) {
  const [data, setData] = useState<FilterList[]>(initialFilterLists);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    (async () => {
      try {
        const lists = await getFilterLists();
        setData(lists);
      } finally {
        setLoading(false);
      }
    })();
  }, [initialFilterLists.length]);

  const table = useReactTable({
    data,
    columns,
    getCoreRowModel: getCoreRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    meta: {
      languages,
      licenses,
      syntaxes,
      tags,
    },
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
