import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Software = {
  id: number;
  name: string | null;
  description: string | null;
  homeUrl: string | null;
  downloadUrl: string | null;
  supportsAbpUrlScheme: boolean;
  syntaxIds: number[] | null;
};

export async function getSoftware(): Promise<Software[]> {
  const response = await fetch(`${API_BASE_URL}/software`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch software: ${response.statusText}`);
  }

  return await response.json();
}
