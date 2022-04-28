export interface FilterListSummary {
  id: number;
  name: string;
  description: string;
  languages: Language[];
  license: string;
  maintainers: string[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}

export interface Language {
  iso6391: string;
  name: string;
}

export interface Software {
  id: number;
  name: string;
}

export interface Syntax {
  name: string;
  description: string;
}

export interface Tag {
  name: string;
  description: string;
}
