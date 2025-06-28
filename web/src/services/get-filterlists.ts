import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type FilterList = {
  id: number;
  name: string;
  description: string | null;
  licenseId: number;
  syntaxIds: readonly number[];
  languageIds: readonly number[];
  tagIds: readonly number[];
  // primaryViewUrl: string | null; // TODO: rm from the API?
  maintainerIds: readonly number[];
};

export async function getFilterLists(): Promise<FilterList[]> {
  const response = await fetch(`${API_BASE_URL}/lists`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch filter lists: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    description: item.description as string | null,
    licenseId: item.licenseId as number,
    syntaxIds: item.syntaxIds as readonly number[],
    languageIds: item.languageIds as readonly number[],
    tagIds: item.tagIds as readonly number[],
    maintainerIds: item.maintainerIds as readonly number[],
  }));
}
