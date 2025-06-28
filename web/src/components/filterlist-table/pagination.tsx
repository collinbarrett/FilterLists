import { Button } from "@/components/ui/button";
import { Table } from "@tanstack/react-table";
import { FilterList } from "@/services/get-filterlists";

type FilterListTablePaginationProps = {
  table: Table<FilterList>;
};

export function FilterListTablePagination({
  table,
}: FilterListTablePaginationProps) {
  return (
    <div className="flex items-center justify-between gap-2">
      <Button
        variant="outline"
        size="sm"
        onClick={() => table.previousPage()}
        disabled={!table.getCanPreviousPage()}
      >
        Previous
      </Button>
      <span className="text-sm">
        Page {table.getState().pagination.pageIndex + 1} of{" "}
        {table.getPageCount()}
      </span>
      <Button
        variant="outline"
        size="sm"
        onClick={() => table.nextPage()}
        disabled={!table.getCanNextPage()}
      >
        Next
      </Button>
    </div>
  );
}
