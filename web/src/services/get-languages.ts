import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Language = {
  id: number;
  iso6391: string;
  name: string;
  // filterListIds: readonly number[]; // TODO: rm from the API?
};

export async function getLanguages(): Promise<Language[]> {
  const response = await fetch(`${API_BASE_URL}/languages`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch languages: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    iso6391: item.iso6391 as string,
    name: item.name as string,
  }));
}
