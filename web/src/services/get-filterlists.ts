import { API_BASE_URL } from "./constants";

export type FilterList = {
  id: number;
  name: string;
  description: string | null;
  licenseId: number;
  syntaxIds: number[];
  languageIds: number[];
  tagIds: number[];
  primaryViewUrl: string | null;
  maintainerIds: number[];
};

export async function getFilterLists(): Promise<FilterList[]> {
  const response = await fetch(`${API_BASE_URL}/lists`, {
    next: { revalidate: 86400 },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch filter lists: ${response.statusText}`);
  }

  return await response.json();
}
