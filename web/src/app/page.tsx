import { FilterListTable } from "@/components/filterlist-table";
import { columns } from "@/components/filterlist-table/columns";
import { getFilterLists } from "@/services/get-filterlists";
import { getLanguages } from "@/services/get-languages";
import { getLicenses } from "@/services/get-licenses";
import { getMaintainers } from "@/services/get-maintainers";
import { getSoftware } from "@/services/get-software";
import { getSyntaxes } from "@/services/get-syntaxes";
import { getTags } from "@/services/get-tags";

export const dynamic = "force-dynamic";

export default async function Home() {
  const [
    filterLists,
    languages,
    licenses,
    maintainers,
    software,
    syntaxes,
    tags,
  ] = await Promise.all([
    getFilterLists(),
    getLanguages(),
    getLicenses(),
    getMaintainers(),
    getSoftware(),
    getSyntaxes(),
    getTags(),
  ]);

  // TODO: add pagination support to API
  const initialFilterLists = filterLists.slice(0, 20);

  return (
    <main className="pt-4 p-8 gap-16 sm:p-20 sm:pt-8">
      <FilterListTable
        columns={columns}
        initialFilterLists={initialFilterLists}
        languages={languages}
        licenses={licenses}
        maintainers={maintainers}
        software={software}
        syntaxes={syntaxes}
        tags={tags}
      />
    </main>
  );
}
