import { FilterListTable } from "@/components/filterlist-table";
import { columns } from "@/components/filterlist-table/columns";
import { getFilterLists } from "@/services/get-filterlists";

export default async function Home() {
  const filterLists = await getFilterLists();

  // TODO: add pagination support to API
  const initialData = filterLists.slice(0, 20);

  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterListTable columns={columns} initialData={initialData} />
    </main>
  );
}
