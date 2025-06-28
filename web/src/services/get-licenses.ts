import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type License = {
  id: number;
  name: string;
  url: string | null;
  // permitsModification: boolean;
  // permitsDistribution: boolean;
  // permitsCommercialUse: boolean;
  // filterListIds: readonly number[]; // TODO: rm from the API?
};

export async function getLicenses(): Promise<License[]> {
  const response = await fetch(`${API_BASE_URL}/licenses`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch licenses: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    url: item.url as string | null,
  }));
}
