import { FilterlistTable, Filterlist } from "@/components/filterlist-table";

const getFilterlists = async (): Promise<Filterlist[]> => {
  const res = await fetch("https://api.filterlists.com/lists", {
    next: { revalidate: 86400 },
  });
  if (!res.ok) throw new Error("Failed to fetch lists");
  return res.json();
};

export default async function Home() {
  const filterlists = await getFilterlists();
  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterlistTable filterlists={filterlists} />
    </main>
  );
}
