import { API_BASE_URL, DEFAULT_REVALIDATE_SECS } from "./constants";

export type ViewUrl = {
  segmentNumber: number;
  primariness: number;
  url: string | null;
};

export type FilterListDetails = {
  id: number;
  name: string;
  description: string | null;
  licenseId: number;
  syntaxIds: number[] | null;
  languageIds: number[] | null;
  tagIds: number[] | null;
  viewUrls: ViewUrl[] | null;
  homeUrl: string | null;
  onionUrl: string | null;
  policyUrl: string | null;
  submissionUrl: string | null;
  issuesUrl: string | null;
  forumUrl: string | null;
  chatUrl: string | null;
  emailAddress: string | null;
  donateUrl: string | null;
  maintainerIds: number[] | null;
  upstreamFilterListIds: number[] | null;
  forkFilterListIds: number[] | null;
  includedInFilterListIds: number[] | null;
  includesFilterListIds: number[] | null;
  dependencyFilterListIds: number[] | null;
  dependentFilterListIds: number[] | null;
};

export async function getFilterListDetails(
  id: number,
): Promise<FilterListDetails> {
  const response = await fetch(`${API_BASE_URL}/lists/${id}`, {
    next: { revalidate: DEFAULT_REVALIDATE_SECS },
  });

  if (!response.ok) {
    if (response.status === 404) {
      throw new Error(`FilterList with ID ${id} not found`);
    }
    throw new Error(
      `Failed to fetch FilterList details: ${response.statusText}`,
    );
  }

  return await response.json();
}
