import {
  Card,
  CardContent,
  CardDescription,
  CardHeader,
  CardTitle,
} from "@/components/ui/card";
import { FilterListsTable } from "@/components/filterlists-table/filterlists-table";

export default function Home() {
  return (
    <div className="grid gap-4 md:gap-8 lg:grid-cols-2 xl:grid-cols-3">
      <Card
        className="col-span-full w-full max-w-full overflow-hidden"
        x-chunk="dashboard-01-chunk-4"
      >
        <CardHeader className="flex flex-row items-center">
          <div className="grid gap-2">
            <CardTitle>FilterLists</CardTitle>
            <CardDescription>
              The independent, comprehensive directory of filter and host lists
              for advertisements, trackers, malware, and annoyances.
            </CardDescription>
          </div>
        </CardHeader>
        <CardContent>
          <FilterListsTable />
        </CardContent>
      </Card>
    </div>
  );
}
