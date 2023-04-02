import { Syntax } from "../interfaces/Syntax";
import { useApiData } from "./useApiData";

export const useSyntaxes = () =>
  (useApiData<Syntax[]>("/api/directory/syntaxes") || []).sort(
    (a: Syntax, b: Syntax) => a.name.localeCompare(b.name)
  );
