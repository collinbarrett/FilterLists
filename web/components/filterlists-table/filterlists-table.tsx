import { DataTable } from "../ui/data-table";
import { columns } from "./columns";
import { FilterList } from "./filterlist";

async function getData(): Promise<FilterList[]> {
  const response = await fetch("https://api.filterlists.com/lists");
  if (!response.ok) {
    throw new Error(`Failed to fetch data: ${response.statusText}`);
  }
  const data: FilterList[] = await response.json();
  return data;
}

export async function FilterListsTable() {
  return <DataTable columns={columns} data={await getData()} />;
}