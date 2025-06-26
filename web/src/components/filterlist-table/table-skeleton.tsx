import { Skeleton } from "@/components/ui/skeleton";
import { FilterListTablePaginationSkeleton } from "./pagination-skeleton";

export function FilterListTableSkeleton() {
  return (
    <div className="space-y-2">
      <div className="overflow-x-auto rounded-md border">
        <table className="min-w-full divide-y divide-gray-200">
          <thead>
            <tr>
              <th className="px-4 py-2 text-left font-medium">
                <Skeleton className="h-6 w-32" />
              </th>
            </tr>
          </thead>
          <tbody>
            {[...Array(10)].map((_, i) => (
              <tr key={i}>
                <td className="px-4 py-2">
                  <Skeleton className="h-5 w-48" />
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
      <FilterListTablePaginationSkeleton />
    </div>
  );
}
