import { Skeleton } from "@/components/ui/skeleton"

interface DataTableSkeletonProps {
  columns?: number
  rows?: number
}

export function DataTableSkeleton({
  columns = 3,
  rows = 5,
}: DataTableSkeletonProps) {
  return (
    <div className="rounded-md border overflow-x-auto">
      <table className="table-fixed w-full">
        <thead>
          <tr>
            {Array.from({ length: columns }).map((_, index) => (
              <th key={index} className="p-4">
                <Skeleton className="h-4 w-full" />
              </th>
            ))}
          </tr>
        </thead>
        <tbody>
          {Array.from({ length: rows }).map((_, rowIndex) => (
            <tr key={rowIndex}>
              {Array.from({ length: columns }).map((_, colIndex) => (
                <td key={colIndex} className="p-4">
                  <Skeleton className="h-4 w-full" />
                </td>
              ))}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}
