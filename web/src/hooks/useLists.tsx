import slugify from "slugify";

import { SlugifyOptions } from "../constants";
import { List } from "../interfaces/List";
import { useApiData } from "./useApiData";

export const useLists = () => {
  const lists = useApiData<List[]>("/api/v1/lists");
  lists && lists.forEach(l => (l.slug = slugify(l.name, SlugifyOptions)));
  return (lists || []).sort((a: List, b: List) => a.name.localeCompare(b.name));
};
