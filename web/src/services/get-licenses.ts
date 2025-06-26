import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type License = {
  id: number;
  name: string | null;
  url: string | null;
  permitsModification: boolean;
  permitsDistribution: boolean;
  permitsCommercialUse: boolean;
  filterListIds: number[] | null;
};

export async function getLicenses(): Promise<License[]> {
  const response = await fetch(`${API_BASE_URL}/licenses`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch licenses: ${response.statusText}`);
  }

  return await response.json();
}
