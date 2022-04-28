export interface FilterListSummary {
  id: number;
  name: string;
  description: string;
  languages: Language[];
  license: string;
  maintainers: string[];
  software: string[];
  syntaxes: string[];
  tags: string[];
}

export interface Language {
  iso6391: string;
  name: string;
}
