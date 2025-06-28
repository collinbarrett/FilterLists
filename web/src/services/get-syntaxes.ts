import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Syntax = {
  id: number;
  name: string;
  description: string | null;
  url: string | null;
  // filterListIds: readonly number[]; // TODO: rm from the API?
  // softwareIds: readonly number[]; // TODO: rm from the API?
};

export async function getSyntaxes(): Promise<Syntax[]> {
  const response = await fetch(`${API_BASE_URL}/syntaxes`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch syntaxes: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    description: item.description as string | null,
    url: item.url as string | null,
  }));
}
