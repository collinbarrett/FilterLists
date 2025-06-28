import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Software = {
  id: number;
  name: string;
  description: string | null;
  homeUrl: string | null;
  // downloadUrl: string | null;
  // supportsAbpUrlScheme: boolean;
  // syntaxIds: readonly number[]; // TODO: rm from the API?
};

export async function getSoftware(): Promise<Software[]> {
  const response = await fetch(`${API_BASE_URL}/software`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch software: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    description: item.description as string | null,
    homeUrl: item.homeUrl as string | null,
  }));
}
