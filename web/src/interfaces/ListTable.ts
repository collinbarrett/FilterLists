import {
  FilterList,
  Language,
  License,
  Maintainer,
  OData,
  Software,
  Syntax,
  Tag,
} from ".";

export interface ListTable {
  filterLists: OData<FilterList[]>;
  languages: Language[];
  licenses: License[];
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
}
