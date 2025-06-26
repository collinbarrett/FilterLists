import { Skeleton } from "@/components/ui/skeleton";

export function FilterListTablePaginationSkeleton() {
  return (
    <div className="flex items-center justify-between gap-2 mt-2">
      <Skeleton className="h-8 w-20" />
      <Skeleton className="h-6 w-24" />
      <Skeleton className="h-8 w-20" />
    </div>
  );
}
