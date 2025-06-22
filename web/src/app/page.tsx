import { FilterListTable } from "@/components/filterlist-table";
import { columns, FilterList } from "@/components/filterlist-table/columns";

async function getInitialFilterLists(): Promise<FilterList[]> {
  const response = await fetch("https://api.filterlists.com/lists", {
    next: { revalidate: 86400 },
  });
  const lists = await response.json();

  // TODO: add pagination support to API
  return lists.slice(0, 20);
}

export default async function Home() {
  const initialData = await getInitialFilterLists();

  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterListTable columns={columns} initialData={initialData} />
    </main>
  );
}
