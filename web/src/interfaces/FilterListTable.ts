import {
  FilterListSummary,
  Language,
  License,
  Maintainer,
  OData,
  Software,
  Syntax,
  Tag,
} from ".";

export interface FilterListTable {
  filterLists: OData<FilterListSummary[]>;
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}
