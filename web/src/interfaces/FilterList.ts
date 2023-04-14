export interface FilterList {
  id: number;
  name: string;
  description?: string;
  licenseId?: number;
  syntaxIds: number[];
  languageIds: number[];
  tagIds: number[];
  maintainerIds: number[];
}
