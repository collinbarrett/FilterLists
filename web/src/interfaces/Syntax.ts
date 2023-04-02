export interface Syntax {
  id: number;
  name: string;
  description?: string;
  url?: string;
  filterListIds: number[];
  softwareIds: number[];
}
