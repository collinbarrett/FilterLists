"use client";

import {
  useReactTable,
  getCoreRowModel,
  getPaginationRowModel,
  flexRender,
  TableMeta,
} from "@tanstack/react-table";
import { columns } from "./columns";
import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table";
import { useEffect, useState } from "react";
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
  languages: Language[];
  licenses: License[];
}

interface FilterListTableProps {
  columns: typeof columns;
  initialFilterLists: FilterList[];
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}

export function FilterListTable({
  columns,
  initialFilterLists,
  languages,
  licenses,
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
