import { Skeleton } from "@/components/ui/skeleton";

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

export function FilterListTablePaginationSkeleton() {
  return (
    <div className="flex items-center justify-between gap-2 mt-2">
      <Skeleton className="h-8 w-20" />
      <Skeleton className="h-6 w-24" />
      <Skeleton className="h-8 w-20" />
    </div>
  );
}
