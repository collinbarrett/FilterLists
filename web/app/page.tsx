import { FilterList, columns } from "./columns";
import { DataTable } from "../components/ui/data-table";
import { ModeToggle } from "@/components/mode-toggle";

async function getData(): Promise<FilterList[]> {
  const response = await fetch("https://api.filterlists.com/lists");
  if (!response.ok) {
    throw new Error(`Failed to fetch data: ${response.statusText}`);
  }
  const data: FilterList[] = await response.json();
  return data;
}

export default async function Home() {
  const data = await getData();

  return (
    <main className="flex min-h-screen flex-col items-center justify-between p-24">
      <div className="absolute top-0 right-0 m-4">
        <ModeToggle />
      </div>
      <div className="container mx-auto py-10">
        <DataTable columns={columns} data={data} />
      </div>
    </main>
  );
}
