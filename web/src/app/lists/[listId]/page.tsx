import {
  getFilterListDetails,
  FilterListDetails,
} from "@/services/get-filterlist-details";

export default async function ListDetailsPage({
  params,
}: {
  params: Promise<{ listId: string }>;
}) {
  const { listId: rawListId } = await params;
  const listId = parseInt(rawListId, 10);
  const list: FilterListDetails = await getFilterListDetails(listId);

  return (
    <div className="container mx-auto py-10">
      <h1 className="text-3xl font-bold mb-4">{list.name}</h1>
      <p className="text-lg mb-6">{list.description}</p>

      <p>Maintainers: {list.maintainerIds?.join(", ")}</p>
      <p>Syntaxes: {list.syntaxIds?.join(", ")}</p>
      <p>Languages: {list.languageIds?.join(", ")}</p>
      <p>License: {list.licenseId}</p>
    </div>
  );
}
