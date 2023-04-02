export interface Maintainer {
  id: number;
  name: string;
  url?: string;
  emailAddress?: string;
  twitterHandle?: string;
  filterListIds: number[];
}
