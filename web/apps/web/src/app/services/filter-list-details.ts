export interface FilterListDetails {
  name: string;
  description: string;
  homeUrl: string;
  onionUrl: string;
  policyUrl: string;
  submissionUrl: string;
  issuesUrl: string;
  forumUrl: string;
  chatUrl: string;
  emailAddress: string;
  donateUrl: string;
  viewUrls: FilterListViewUrl[];
  languages: Language[];
  license: License;
  maintainers: Maintainer[];
  software: Software[];
  syntaxes: Syntax[];
  tags: Tag[];
  upstreamFilterLists: RelatedFilterList[];
  forkFilterLists: RelatedFilterList[];
  includedInFilterLists: RelatedFilterList[];
  includesFilterLists: RelatedFilterList[];
  dependencyFilterLists: RelatedFilterList[];
  dependentFilterLists: RelatedFilterList[];
}

export interface FilterListViewUrl {
  segmentNumber: number;
  primariness: number;
  url: string;
}

export interface Language {
  iso6391: string;
  name: string;
}

export interface License {
  id: number;
  name: string;
  url: string;
  permitsModification: boolean;
  permitsDistribution: boolean;
  permitsCommercialUse: boolean;
}

export interface Maintainer {
  id: number;
  name: string;
  url: string;
  emailAddress: string;
  twitterHandle: string;
}

export interface Software {
  id: number;
  name: string;
}

export interface Syntax {
  id: number;
  name: string;
  description: string;
  url: string;
}

export interface Tag {
  id: number;
  name: string;
  description: string;
}

export interface RelatedFilterList {
  id: number;
  name: string;
}
