import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type FilterList = {
  id: number;
  name: string;
  description: string | null;
  licenseId: number;
  syntaxIds: readonly number[];
  languageIds: readonly number[];
  tagIds: readonly number[];
  primaryViewUrl: string | null;
  maintainerIds: readonly number[];
};

export async function getFilterLists(): Promise<FilterList[]> {
  const response = await fetch(`${API_BASE_URL}/lists`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch filter lists: ${response.statusText}`);
  }

  return await response.json();
}
