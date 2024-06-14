export interface ListDetails {
  id: number;
  name: string;
  description?: string;
  licenseId?: number;
  syntaxIds: number[];
  languageIds: number[];
  tagIds: number[];
  viewUrls: ViewUrl[];
  homeUrl?: string;
  onionUrl?: string;
  policyUrl?: string;
  submissionUrl?: string;
  issuesUrl?: string;
  forumUrl?: string;
  chatUrl?: string;
  emailAddress?: string;
  donateUrl?: string;
  maintainerIds: number[];
  upstreamFilterListIds: number[];
  forkFilterListIds: number[];
  includedInFilterListIds: number[];
  includesFilterListIds: number[];
  dependencyFilterListIds: number[];
  dependentFilterListIds: number[];
}

export interface ViewUrl {
  segmentNumber: number;
  primariness: number;
  url: string;
}
