"use client";

import { useEffect, useState } from "react";
import {
  flexRender,
  getCoreRowModel,
  getPaginationRowModel,
  getSortedRowModel,
  TableMeta,
  useReactTable,
} from "@tanstack/react-table";
import {
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table";
import { useCalculatePageSize } from "./use-calculate-page-size";
import { FilterList, getFilterLists } from "@/services/get-filterlists";
import { Language } from "@/services/get-languages";
import { License } from "@/services/get-licenses";
import { Maintainer } from "@/services/get-maintainers";
import { Software } from "@/services/get-software";
import { Syntax } from "@/services/get-syntaxes";
import { Tag } from "@/services/get-tags";
import { columns } from "./columns";
import { FilterListTablePagination } from "./pagination";
import { FilterListTablePaginationSkeleton } from "./pagination-skeleton";

export interface FilterListsTableMeta extends TableMeta<FilterList> {
  languages: readonly Language[];
  licenses: readonly License[];
  maintainers: readonly Maintainer[];
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
  maintainers,
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
  }, []);

  const table = useReactTable({
    data,
    columns,
    columnResizeMode: "onChange",
    getCoreRowModel: getCoreRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    getSortedRowModel: getSortedRowModel(),
    meta: {
      languages,
      licenses,
      maintainers,
      syntaxes,
      tags,
    },
  });

  useCalculatePageSize(table.setPageSize);

  return (
    <div className="space-y-2">
      <Table
        style={{
          width: table.getCenterTotalSize(),
          tableLayout: "fixed",
        }}
      >
        <TableHeader>
          {table.getHeaderGroups().map((headerGroup) => (
            <TableRow key={headerGroup.id}>
              {headerGroup.headers.map((header) => (
                <TableHead
                  key={header.id}
                  colSpan={header.colSpan}
                  style={{ width: header.getSize() }}
                  className="relative"
                >
                  {flexRender(
                    header.column.columnDef.header,
                    header.getContext(),
                  )}
                  <div
                    onMouseDown={header.getResizeHandler()}
                    onTouchStart={header.getResizeHandler()}
                    className={`resizer ${
                      header.column.getIsResizing() ? "isResizing" : ""
                    }`}
                  />
                </TableHead>
              ))}
            </TableRow>
          ))}
        </TableHeader>
        <TableBody>
          {table.getRowModel().rows.map((row) => (
            <TableRow key={row.id} className="h-16">
              {row.getVisibleCells().map((cell) => (
                <TableCell
                  key={cell.id}
                  style={{ width: cell.column.getSize() }}
                  className="relative"
                >
                  <div className="h-11 overflow-hidden">
                    {flexRender(cell.column.columnDef.cell, cell.getContext())}
                  </div>
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
