import { FilterListTableSkeleton } from "@/components/filterlist-table/skeleton";

export default function Loading() {
  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterListTableSkeleton />
    </main>
  );
}
