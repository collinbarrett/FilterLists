import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Syntax = {
  id: number;
  name: string | null;
  description: string | null;
  url: string | null;
  filterListIds: readonly number[] | null;
  softwareIds: readonly number[] | null;
};

export async function getSyntaxes(): Promise<Syntax[]> {
  const response = await fetch(`${API_BASE_URL}/syntaxes`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch syntaxes: ${response.statusText}`);
  }

  return await response.json();
}
