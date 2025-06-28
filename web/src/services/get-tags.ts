import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Tag = {
  id: number;
  name: string;
  description: string | null;
  // filterListIds: readonly number[]; // TODO: rm from the API?
};

export async function getTags(): Promise<Tag[]> {
  const response = await fetch(`${API_BASE_URL}/tags`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch tags: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    description: item.description as string | null,
  }));
}
