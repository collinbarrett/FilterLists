import {
  getFilterListDetails,
  FilterListDetails,
} from "@/services/get-filterlist-details";
import { SheetContentRenderer } from "@/components/sheet-content-renderer";

export default async function InterceptedListDetailsPage({
  params,
}: {
  params: Promise<{ listId: string }>;
}) {
  const { listId: rawListId } = await params;
  const listId = parseInt(rawListId, 10);
  const list: FilterListDetails = await getFilterListDetails(listId);

  return <SheetContentRenderer list={list} />;
}
