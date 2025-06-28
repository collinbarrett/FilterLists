import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Maintainer = {
  id: number;
  name: string | null;
  url: string | null;
  emailAddress: string | null;
  twitterHandle: string | null;
  filterListIds: readonly number[] | null;
};

export async function getMaintainers(): Promise<Maintainer[]> {
  const response = await fetch(`${API_BASE_URL}/maintainers`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch maintainers: ${response.statusText}`);
  }

  return await response.json();
}
