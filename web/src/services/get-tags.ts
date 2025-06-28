import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Tag = {
  id: number;
  name: string | null;
  description: string | null;
  filterListIds: readonly number[] | null;
};

export async function getTags(): Promise<Tag[]> {
  const response = await fetch(`${API_BASE_URL}/tags`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch tags: ${response.statusText}`);
  }

  return await response.json();
}
