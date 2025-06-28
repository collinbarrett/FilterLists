import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Language = {
  id: number;
  iso6391: string;
  name: string;
};

export async function getLanguages(): Promise<Language[]> {
  const response = await fetch(`${API_BASE_URL}/languages`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch languages: ${response.statusText}`);
  }

  return await response.json();
}
