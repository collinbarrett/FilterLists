import { FilterListTable } from "@/components/filterlist-table";
import { columns, FilterList } from "@/components/filterlist-table/columns";

async function getFilterLists(): Promise<FilterList[]> {
  const filterLists = await fetch("https://api.filterlists.com/lists", {
    next: { revalidate: 86400 },
  });
  return await filterLists.json();
}

export default async function Home() {
  const filterLists = await getFilterLists();

  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterListTable columns={columns} data={filterLists} />
    </main>
  );
}
