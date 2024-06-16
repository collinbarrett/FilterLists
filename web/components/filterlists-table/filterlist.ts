export type FilterList = {
  id: number;
  name: string;
  description?: string | null;
  licenseId: number;
  syntaxIds: number[];
  languageIds: number[];
  tagIds: number[];
  primaryViewUrl?: string | null;
  maintainerIds: number[];
};
