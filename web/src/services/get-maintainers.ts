import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type Maintainer = {
  id: number;
  name: string;
  url: string | null;
  // emailAddress: string | null;
  // twitterHandle: string | null;
  // filterListIds: readonly number[]; // TODO: rm from the API?
};

export async function getMaintainers(): Promise<Maintainer[]> {
  const response = await fetch(`${API_BASE_URL}/maintainers`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    throw new Error(`Failed to fetch maintainers: ${response.statusText}`);
  }

  const data = await response.json();
  return data.map((item: Record<string, unknown>) => ({
    id: item.id as number,
    name: item.name as string,
    url: item.url as string | null,
  }));
}
