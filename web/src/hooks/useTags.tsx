import { Tag } from "../interfaces/Tag";
import { useApiData } from "./useApiData";

export const useTags = () =>
  (useApiData<Tag[]>("https://api.filterlists.com/tags") || []).sort(
    (a: Tag, b: Tag) => a.name.localeCompare(b.name),
  );
